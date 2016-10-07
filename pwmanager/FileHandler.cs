using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwmanager {
    class FileHandler {

        public static List<Info> initFile(string password, string path) {
            using(StreamWriter sw = new StreamWriter(path)) {
                List<Info> info = new List<Info>();
                //Write password hash first line
                sw.WriteLine(PasswordHash.HashPassword(password));

                var binFormatter = new BinaryFormatter();
                var memStream = new MemoryStream();
                binFormatter.Serialize(memStream, info);

                sw.WriteLine(PasswordHash.HashPassword(Encoding.Default.GetString(memStream.ToArray())));
                return info;
            }
        }

        public static void saveFile(string password, string path, List<Info> info) {
            //try {
                using (StreamWriter sw = new StreamWriter(path)) {
                    //Write password hash first line
                    sw.WriteLine(PasswordHash.HashPassword(password));

                    //Write all encrypted account details line by line
                    for (int i = 0; i < info.Count; i++) {
                        Info temp = info[i];
                        MessageBox.Show(temp.ToString());
                        sw.WriteLine(Encrypt.EncryptString(temp.label, password) + ":" + Encrypt.EncryptString(temp.username, password) + ":"
                            + Encrypt.EncryptString(temp.password, password));
                    }

                    //Write checksum
                    
                    var binFormatter = new BinaryFormatter();
                    var memStream = new MemoryStream();
                    binFormatter.Serialize(memStream, info);

                    sw.WriteLine(PasswordHash.HashPassword(Encoding.Default.GetString(memStream.ToArray())));
                }
            /*}
            catch(Exception ex) {
                MessageBox.Show("File save failed");
                Console.WriteLine(ex.ToString());
            }*/
        }


        public static List<Info> openFile(string password, string path) {
            using (StreamReader sr = new StreamReader(path)) {
                string hash = sr.ReadLine();

                if (PasswordHash.ValidatePassword(password, hash)) {
                    string line;

                    while ((line = sr.ReadLine()) != null) {
                        List<Info> userInfo = new List<Info>();

                        if (line.Contains(":")) {
                            //It's a line of account info
                            string[] split = line.Split(':');
                            Info temp = new Info();
                            //Load values into Info data structure for organization
                            temp.label = Encrypt.DecryptString(split[0], password);
                            temp.username = Encrypt.DecryptString(split[1], password);
                            temp.password = Encrypt.DecryptString(split[2], password);
                            //Put the new Info object into a list
                            userInfo.Add(temp);
                        }
                        else {
                            //It's the checksum
                            var binFormatter = new BinaryFormatter();
                            var memStream = new MemoryStream();
                            binFormatter.Serialize(memStream, userInfo);
                     
                            if (PasswordHash.ValidatePassword(Encoding.Default.GetString(memStream.ToArray()), line)) {
                                //Hashes match, no tampering
                                return userInfo;
                            }
                            else {
                                MessageBox.Show("The file has been tampered with and cannot be opened.");
                                return null;
                            }
                        }
                    }
                }
                else {
                    MessageBox.Show("Invalid password.");
                }
            }
            return null;
        }
    }
}

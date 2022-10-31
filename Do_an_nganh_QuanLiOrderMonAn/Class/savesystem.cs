using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Diagnostics;

namespace Do_an_nganh_QuanLiOrderMonAn.DTO
{
    class savesystem
    {
        public static void save(Account data)
        {
            BinaryFormatter filesave = new BinaryFormatter();
            const string path = "data.caigidoratgivanayno";
            FileStream stream = new FileStream(path, FileMode.Create);

            filesave.Serialize(stream, data);
            stream.Close();
        }
        public static Account load()
        {
            string path = "data.caigidoratgivanayno";
            if (File.Exists(path))
            {

                BinaryFormatter filesave = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);
                return filesave.Deserialize(stream) as Account;
            }
            else
            {
                //System.Windows.Forms.MessageBox.Show(@"lam j co file nay  !!!!!!!");
                return null;
            }

        }
    }
   
}

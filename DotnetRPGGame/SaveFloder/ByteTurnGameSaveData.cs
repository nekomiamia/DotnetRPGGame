using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DotnetRPGGame.SaveFloder
{
    public class ByteTurnGameSaveData
    {
        public GameSaveData BToGameSaveData(byte[] b)
        {
            GameSaveData _gameSaveData;
            //定义一个流
            MemoryStream stream = new MemoryStream(b);
            //定义一个格式化器
            BinaryFormatter bf = new BinaryFormatter(); 
            ArrayList arrayList = new ArrayList();
            while (stream.Position != stream.Length)
            {
                arrayList.Add(bf.Deserialize(stream)); //反序列化
            }
            stream.Close();
            if (arrayList.Count==0)
            {
                return null;
            }
            return (GameSaveData) arrayList[0];
        }
        
        public byte[] GToByte(GameSaveData g)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(g);
            //定义一个流
            Stream stream = new MemoryStream();
            //定义一个格式化器
            BinaryFormatter bf = new BinaryFormatter();
            foreach (object obj in arrayList)
            {
                bf.Serialize(stream, obj);  //序列化
            }
            byte[] array = null;
            array = new byte[stream.Length];
            //将二进制流写入数组
            stream.Position = 0;
            stream.Read(array, 0, (int)stream.Length);
            //关闭流
            stream.Close();
            return array;
        }
    }
}
using System.IO;
using NeuraNet.Serialization;
using PatternRecognizer.BL.Network;

namespace PatternRecognizer.BL.NeuraNet
{
    /// <summary>
    /// Предоставляет класс для управления получением нейронной сети из файла и сохранением ее в файл.
    /// </summary>
    public class NeuraNetFileManager : INetworkManager
    {
        public bool IsExist(string path)
        {
            return File.Exists(path.ToString());
        }

        public INeuralNetwork GetNeuralNetwork(string path)
        {
            var content = File.ReadAllText(path);
            return new NeuraNet(new NetworkJsonConverter().Deserialize(content));
        }

        public void SaveNeuralNetwork(INeuralNetwork network, string path)
        {
            var content = new NetworkJsonConverter().Serialize((network as NeuraNet).Network);
            File.WriteAllText(path, content);
        }
    }
}

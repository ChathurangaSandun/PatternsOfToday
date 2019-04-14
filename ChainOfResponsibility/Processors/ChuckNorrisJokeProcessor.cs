using ChainOfResponsibility.Models;
using Newtonsoft.Json;

namespace ChainOfResponsibility.Processors
{
    public class ChuckNorrisJokeProcessor : IJokeProcessor
    {
        public bool CanProcess(int type) => type == 2;

        public Joke Process()
        {
            return JsonConvert.DeserializeObject<Joke>(@"{id: 1057, contents: ""Chuck Norris uses pepper spray to spice up his steaks.""}");
        }
    }
}

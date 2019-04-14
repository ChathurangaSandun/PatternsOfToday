using ChainOfResponsibility.Models;
using Newtonsoft.Json;

namespace ChainOfResponsibility.Processors
{
    public class DadJokeProcessor : IJokeProcessor
    {
        public bool CanProcess(int type) => type == 1;

        public Joke Process()
        {
            return JsonConvert.DeserializeObject<Joke>(@"{id: 56, contents: ""Today my son asked, \""Can I have a bookmark?\"" and I burst into tears.  11 years old and he still doesn't know my name is Jason""}");
        }
    }
}

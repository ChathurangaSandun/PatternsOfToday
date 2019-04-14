using System.Threading.Tasks;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Processors
{
    public interface IJokeProcessor
    {
        bool CanProcess(int type);
        Joke Process();
    }
}

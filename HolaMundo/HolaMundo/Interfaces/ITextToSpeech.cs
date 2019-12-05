using System;
using System.Threading.Tasks;

namespace HolaMundo.Interfaces
{
    public interface ITextToSpeech
    {
        Task LeerEnVozAlta(string texto);
    }
}

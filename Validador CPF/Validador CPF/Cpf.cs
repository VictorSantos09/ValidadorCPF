using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validador_CPF
{
    public class Cpf
    {
        public string CpfNumero { get; set; }
        public bool LetterChecker()
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < alfabeto.Length; i++)
            {
                char letraAlfabeto = alfabeto[i];
                for (int j = 0; j < CpfNumero.Length; j++)
                {
                    if (CpfNumero.ToUpper()[j] == letraAlfabeto)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool CpfLenghtChecker()
        {
            if (CpfNumero.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

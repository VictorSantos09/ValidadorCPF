using Validador_CPF;

bool userUsing = true;
Cpf cpf = new Cpf();

bool looping = true;
while (looping)
{
    Console.WriteLine("Informe um CPF: ");
    cpf.CpfNumero = Console.ReadLine();
    bool lenghtOk = cpf.CpfLenghtChecker();
    if (lenghtOk == true)
    {
        Console.WriteLine("Tamanho válido\n");
    }
    if(lenghtOk == false)
    {
        Console.WriteLine("Tamanho inválido\n");
    }
    bool caracteresValidos = cpf.LetterChecker();
    if (caracteresValidos == true)
    {
        Console.WriteLine("CPF não contém Letras\n");
    }
    else
    {
        Console.WriteLine("CPF contém Letras, tente novamente\n");
    }
    if (caracteresValidos && lenghtOk == true)
    {
        Console.WriteLine(Convert.ToUInt64(cpf.CpfNumero).ToString(@"CPF: 000\.000\.000\-00"));
        looping = false;
    }
}
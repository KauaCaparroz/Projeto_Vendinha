namespace Projeto_Vendinha
{
    public class ValidadorCPF
    {
        // Verifica se o CPF é válido
        public static bool Validar(string cpf)
        {
            // Remove pontos e traços
            cpf = cpf.Replace(".", "").Replace("-", "");

            // Verifica se o CPF tem 11 números
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os caracteres são números
            foreach (char numero in cpf)
            {
                if (!char.IsDigit(numero))
                    return false;
            }

            // Impede CPF com todos os números iguais
            if (cpf == new string(cpf[0], 11))
                return false;

            // Verifica os dois últimos dígitos do CPF
            for (int tamanho = 9; tamanho <= 10; tamanho++)
            {
                int soma = 0;

                for (int i = 0; i < tamanho; i++)
                {
                    int numero = cpf[i] - '0';
                    soma += numero * (tamanho + 1 - i);
                }

                int resto = soma % 11;
                int digito = 0;

                if (resto >= 2)
                    digito = 11 - resto;

                if (digito != cpf[tamanho] - '0')
                    return false;
            }

            // Se passou por todas as verificações, o CPF é válido
            return true;
        }
    }
}
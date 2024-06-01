namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;
            // IMPLEMENTADO!!!
            bool sucesso = false;

            try
            {
                if (hospedes.Count() <= Suite.Capacidade)
                    {
                        sucesso = true;
                    }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Capacidade menor que a quantidade de hóspedes.", ex.Message);
            }
            if (sucesso)
            {
                Hospedes = hospedes;
            }
            else
            {
                // IMPLEMENTADO!!!
                throw new ArgumentException("Capacidade menor que a quantidade de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // IMPLEMENTADO!!!
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // IMPLEMENTADO!!!
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // IMPLEMENTADO!!!
            if (DiasReservados > 9)
            {
                valor = valor - (10/100)*valor;
            }

            return valor;
        }
    }
}
namespace RM557992.Domain.Entities
{
    public class Carro
    {
        public int Id { get; private set; }
        public string Placa { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }

        public Carro(string placa, string modelo, int ano)
        {
            SetPlaca(placa);
            SetModelo(modelo);
            SetAno(ano);
        }

        public void SetPlaca(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa))
                throw new ArgumentException("Placa é obrigatória.");
            if (placa.Length != 7)
                throw new ArgumentException("Placa deve conter 7 caracteres.");
            Placa = placa.ToUpper();
        }

        public void SetModelo(string modelo)
        {
            if (string.IsNullOrWhiteSpace(modelo))
                throw new ArgumentException("Modelo é obrigatório.");
            Modelo = modelo;
        }

        public void SetAno(int ano)
        {
            var anoAtual = DateTime.Now.Year;
            if (ano < 1980 || ano > anoAtual + 1)
                throw new ArgumentException("Ano inválido.");
            Ano = ano;
        }

        public bool EhAntigo()
        {
            return Ano < 2000;
        }
    }
}

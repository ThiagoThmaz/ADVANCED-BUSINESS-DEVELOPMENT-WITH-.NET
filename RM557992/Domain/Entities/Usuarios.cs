namespace RM557992.Domain.Entities

{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        private List<Carro> _carros = new();
        public IReadOnlyCollection<Carro> Carros => _carros;

        public Usuario(string nome, string email)
        {
            SetNome(nome);
            SetEmail(email);
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome é obrigatório.");
            Nome = nome;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                throw new ArgumentException("Email inválido.");
            Email = email;
        }

        public void AdicionarCarro(Carro carro)
        {
            if (carro == null)
                throw new ArgumentException("Carro não pode ser nulo.");
            _carros.Add(carro);
        }
    }
}

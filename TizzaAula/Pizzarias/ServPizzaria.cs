namespace TizzaAula
{
    public interface IServPizzaria
    {
        void Inserir(Pizzaria pizzaria);
        void Alterar(int id, AlterarPizzariaDTO alterarPizzariaDto);
    }

    public class ServPizzaria : IServPizzaria
    {
        private DataContext _dataContext;

        public ServPizzaria(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Inserir(Pizzaria pizzaria)
        {
            _dataContext.Add(pizzaria);

            _dataContext.SaveChanges();
        }

        public void Alterar(int id, AlterarPizzariaDTO alterarPizzariaDto)
        {
            var pizzaria = _dataContext.Pizzaria.Where(p => p.Id == id).FirstOrDefault();

            pizzaria.Nome = alterarPizzariaDto.Nome;
            pizzaria.Endereco = alterarPizzariaDto.Endereco;
            pizzaria.Telefone = alterarPizzariaDto.Telefone;

            _dataContext.SaveChanges();
        }
    }
}

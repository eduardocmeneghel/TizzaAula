namespace TizzaAula
{
    public interface IServPromover
    {
        void Inserir(InserirPromoverDTO inserirDto);
    }

    public class ServPromover : IServPromover
    {
        private DataContext _dataContext;

        public ServPromover(DataContext dataContext)
        {

            _dataContext = dataContext;

        }

        public void Inserir(InserirPromoverDTO inserirDto)
        {
            var promover = new Promover();

            promover.Descricao = inserirDto.Descricao;
            promover.CodigoPizzaria = inserirDto.CodigoPizzaria;
            promover.DataVigencia = inserirDto.DataVigencia;
            promover.Valor = inserirDto.Valor;

            promover.Status = EnumStatusPromover.EmAberto;

            _dataContext.Add(promover);
            _dataContext.SaveChanges();
        }
    }
}

using MediatR;

namespace NerdStore.Catalogo.Domain.Events
{
    public class ProdutoEventHandrer : INotificationHandler<ProdutoAbaixoEstoqueEvents>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoEventHandrer(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Handle(ProdutoAbaixoEstoqueEvents notification, CancellationToken cancellationToken)
        {
            var produto = _produtoRepository.ObterPorId(notification.AggregateId);

            //Aqui pode colocar a maneira como será alertado para o usuario. Por email, bot no Telegram e etc.
        }
    }
}

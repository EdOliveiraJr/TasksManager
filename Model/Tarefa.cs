using TasksManager.Enum;

namespace TasksManager.Model
{
    internal class Tarefa
    {
        internal Guid _id { get; private set; }
        private string _titulo { get; set; }
        private string _desrcicao {  get; set; }   
        private Usuario? _criador { get; set; }
        private Usuario? _responsavel { get; set; }
        private DateTime _criacao { get; set; }
        private DateTime _conclusao { get; set; }
        private EstadoTarefa _estado { get; set; }

        public Tarefa(Usuario? criador, Usuario? responsavel, string titulo, string descricao)
        {
            this._id = Guid.NewGuid();
            this._titulo = titulo;
            this._desrcicao = descricao;
            this._criador = criador;
            this._responsavel = responsavel;
            this._criacao = DateTime.Now;
            this._conclusao = DateTime.Now.AddDays(7);
            this._estado = EstadoTarefa.Pendente;
        }

        public override string ToString()
        {
            return $"id: {_id}\n" +
                $"Título: {_titulo}\n" +
                $"Descricao: {_desrcicao}\n" +
                $"Criador: {_criador}\n" +
                $"Responsável: {_responsavel}\n" +
                $"Criada em: {_criacao}\n" +
                $"Concluida em: {_conclusao}\n" +
                $"Situação: {_estado}";
        }
    }
}
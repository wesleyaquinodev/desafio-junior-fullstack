using System;

namespace desafio_junior_backend
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public StatusTarefa Status { get; set; }

        public TaskItem()
        {
            DataCriacao = DateTime.Now;
            Status = StatusTarefa.Pendente;
        }

        public TaskItem(int id, string titulo, string descricao)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = DateTime.Now;
            Status = StatusTarefa.Pendente;
        }
    }

    public enum StatusTarefa
    {
        Pendente,
        EmAndamento,
        Concluida
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace desafio_junior_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private static readonly List<TaskItem> _tasks = new List<TaskItem>
        {
            new TaskItem(1, "Finalizar relatório", "Escrever o relatório final do projeto.")
        };

        /// <summary>
        /// Cria uma nova tarefa.
        /// </summary>
        /// <param name="titulo">Título da tarefa.</param>
        /// <param name="descricao">Descrição da tarefa.</param>
        /// <returns>Retorna a tarefa criada.</returns>
        [HttpPost]
        public IActionResult Create([FromQuery] string titulo, [FromQuery] string descricao)
        {
            int newId = _tasks.Any() ? _tasks.Max(t => t.Id) + 1 : 1;
            TaskItem newTask = new TaskItem(newId, titulo, descricao);
            _tasks.Add(newTask);
            // Retorna 201 Created com a rota para obter a tarefa criada
            return CreatedAtAction(nameof(GetById), new { id = newTask.Id }, newTask);
        }

        /// <summary>
        /// Recupera uma tarefa pelo ID.
        /// </summary>
        /// <param name="id">Identificador da tarefa.</param>
        /// <returns>Retorna a tarefa encontrada ou NotFound se não existir.</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        /// <summary>
        /// Recupera todas as tarefas.
        /// </summary>
        /// <returns>Lista com todas as tarefas.</returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_tasks);
        }

        /// <summary>
        /// Atualiza uma tarefa existente.
        /// </summary>
        /// <param name="id">Identificador da tarefa.</param>
        /// <param name="titulo">Novo título para a tarefa (opcional).</param>
        /// <param name="descricao">Nova descrição para a tarefa (opcional).</param>
        /// <returns>Retorna a tarefa atualizada ou NotFound se não existir.</returns>
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromQuery] string? titulo, [FromQuery] string? descricao)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }

            task.Titulo = titulo ?? task.Titulo;
            task.Descricao = descricao ?? task.Descricao;

            return Ok(task);
        }

        /// <summary>
        /// Exclui uma tarefa pelo ID.
        /// </summary>
        /// <param name="id">Identificador da tarefa.</param>
        /// <returns>Retorna NoContent se a exclusão for realizada ou NotFound se não existir.</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            _tasks.Remove(task);
            return NoContent();
        }
    }
}

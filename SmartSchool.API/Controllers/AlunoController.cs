using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartSchool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Eliseu",
                SobreNome = "Oliveira",
                Telefone = "123456789"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Allana",
                SobreNome = "Ataides",
                Telefone = "645673232"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Elias",
                SobreNome = "Oliveira",
                Telefone = "124523562"
            }
        };

        public AlunoController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        //aluno/1
        [HttpGet("byId/{Id}")]
        public IActionResult GetByIds(int Id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == Id);
            if (aluno == null) return BadRequest("Aluno não encontrado.");
            return Ok(aluno);
        }

        //aluno/byId?Id=1
        [HttpGet("byId")]
        public IActionResult GetById(int Id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == Id);
            if (aluno == null) return BadRequest("Aluno não encontrado.");
            return Ok(aluno);
        }

        //aluno/ByName?nome=Allana&sobrenome=Ataides
        [HttpGet("ByName")]
        public IActionResult GetByNome(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.SobreNome.Contains(sobrenome));
            if (aluno == null) return BadRequest("Aluno não encontrado.");
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{Id}")]
        public IActionResult Put(int Id, Aluno aluno)
        {
            return Ok(aluno);
        }

        //api/aluno
        [HttpPatch("{Id}")]
        public IActionResult Patch(int Id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Teste.Models;


namespace Teste.Controllers
{
    public class DadosController : Controller
    {
        // Ação para exibir a lista de pacientes e suas calorias


        public IActionResult ListaPaciente()
        {
            List<Paciente> pacientes = ObterPaciente();
            List<Caloria> calorias = ObterCaloria();

            ViewBag.Paciente = pacientes;
            ViewBag.Caloria = calorias;

            return View();
        }

        private List<Paciente> ObterPaciente()
        {
            using (var contexto = new Contexto()) // Substitua "SeuContextoDeBancoDeDados" pelo nome correto do seu contexto de banco de dados
            {
                List<Paciente> pacientes = contexto.Paciente.ToList();

                return pacientes;
            }
        }

        private List<Caloria> ObterCaloria()
        {
            using (var contexto = new Contexto()) // Substitua "SeuContextoDeBancoDeDados" pelo nome correto do seu contexto de banco de dados
            {
                List<Caloria> calorias = contexto.Caloria.ToList();

                return calorias;
            }
        }
    }
}

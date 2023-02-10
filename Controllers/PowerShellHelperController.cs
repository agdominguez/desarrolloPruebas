using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Management.Automation;

namespace PowerShellAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PowerShellHelperController : ControllerBase
    {
        [HttpPost("HabilitarUsuario")]
        public void ExecuteHabilita(string usuario, bool estaHabilitado)
        {
            using (var ps = PowerShell.Create())
            {
                //var results = ps.AddScript(command).Invoke();
                //foreach (var result in results)
                //{
                //    Debug.Write(result.ToString());
                //}
            }
        }

        [HttpPost("BloqueaUsuario")]
        public void ExecuteBloquea(string usuario)
        {
            using (var ps = PowerShell.Create())
            {
                //var results = ps.AddScript(command).Invoke();
                //foreach (var result in results)
                //{
                //    Debug.Write(result.ToString());
                //}
            }
        }


    }
}

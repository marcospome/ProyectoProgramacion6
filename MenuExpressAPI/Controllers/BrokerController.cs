using Microsoft.AspNetCore.Mvc;
using ProyectoProgramacion.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoProgramacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrokerController : ControllerBase
    {
        // GET: api/<BrokerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/<BrokerController>/5
        [HttpGet("operationsByYear")]
        public List<Actions> GetOperationsByYear(int year)
        {
            List<Actions> actionsList = new List<Actions>();
            for (int i = 0 /* Valor inicial del ciclo */; i < 10 /* Mientras i sea menor al valor va a repetirs el ciclo */; i++ /* Se incrementa el valor de i+1 */)
            {
                Actions action = new Actions(); // Defino el elemento.
                action.OrderDate = DateTime.Now;
                action.Action = "BUY";
                action.Status = "PENDING";
                action.TxNumber = i;
                action.Quantity = year;
                action.Symbol = "AAPL";
                action.Price = ( i + 100 )* 500;
                actionsList.Add(action); // Agrega elemento a la lista.

            }

            return actionsList;
        }

       
        // POST api/<BrokerController>
        [HttpPost("orderCreate")]
        public string CreateOrder(List<Actions> accion)  // si pongo List<Action> puedo enviar varios elementos en un solo json.
        {
            foreach (Actions action in accion)
            {
                string valorej = action.Status; 
            }
            return "";
        }

        // PUT api/<BrokerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BrokerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

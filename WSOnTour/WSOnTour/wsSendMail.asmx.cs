using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;

namespace WSOnTour
{
    /// <summary>
    /// Descripción breve de wsSendMail
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsSendMail : System.Web.Services.WebService
    {

        [WebMethod]
        public async Task<string> SendMailPaid(
            string reciber,
            string nombre_apoderado,
            string nombre_alumno,
            int monto_abonado)
        {
            var text = $"Estimad@ {nombre_apoderado}, hemos confirmado su pago " +
                $"para el alumno {nombre_alumno} por el monto de ${monto_abonado}";
            var client = new SendGridClient("");
            var from = new EmailAddress("no-reply@ontour.cl", "Departamento de pagos");
            var subject = "Confirmacion de Pago";
            var to = new EmailAddress(reciber, nombre_apoderado);
            var plainTextContent = text;
            var htmlContent = $"<strong>{text}</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            return "dasda";
        }

        [WebMethod]
        public async Task<string> SendMailActivityPaid(
            string reciber,
            string nombre_apoderado,
            string curso,
            int monto_abonado)
        {
            var text = $"Estimad@ {nombre_apoderado}, hemos confirmado su pago de actividad " +
                $"para el curso {curso} por el monto de ${monto_abonado}";
            var client = new SendGridClient("");
            var from = new EmailAddress("no-reply@ontour.cl", "Departamento de pagos");
            var subject = "Confirmacion de Pago";
            var to = new EmailAddress(reciber, nombre_apoderado);
            var plainTextContent = text;
            var htmlContent = $"<strong>{text}</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            return "dasda";
        }
    }
}

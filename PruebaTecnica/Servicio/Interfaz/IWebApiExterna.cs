﻿using PruebaTecnica.Models;

namespace PruebaTecnica.Servicio.Interfaz
{
    public interface IWebApiExterna
    {
        DatoApiModels TraerDatosApi(string code, string country, string name);
    }
}

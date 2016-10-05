﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoInge1.Models;

namespace ProyectoInge1.Controllers
{
    public class UsuariosController : Controller
    {
        BD_IngeGrupo4Entities1 BD = new BD_IngeGrupo4Entities1();
        // GET: Usuarios
        public ActionResult Index( string sortOrder )
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Proy" ? "proy_desc" : "Proy";
            var usuarios = from users in BD.Usuario
                           select users;
            var proyectos = from proy in BD.Proyecto
                            select proy;
            switch (sortOrder)
            {
                case "name_desc":
                    usuarios = usuarios.OrderByDescending(users => users.apellidos);
                    break;
                case "Proy":
                    proyectos = proyectos.OrderBy(proy => proy.nombre);
                    break;
                case "proy_desc":
                    proyectos = proyectos.OrderByDescending(proy => proy.nombre);
                    break;
                default:
                    usuarios = usuarios.OrderBy(users => users.apellidos);
                    break;
            }
            ModUsuarioInter modelo = new ModUsuarioInter();
            modelo.listaUsuarios = usuarios.ToList();
            modelo.listaProyectos = proyectos.ToList();
            return View(modelo);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModUsuarioInter modelo)
        {
            if (ModelState.IsValid)
            {
                BD.Usuario.Add(modelo.modeloUsuario);
                BD.SaveChanges();

                if (modelo.modeloTelefono1.numero != null)
                {
                    modelo.modeloTelefono1.usuario = modelo.modeloUsuario.cedula;
                    BD.Telefono.Add(modelo.modeloTelefono1);
                }
                if (modelo.modeloTelefono2.numero != null)
                {
                    modelo.modeloTelefono2.usuario = modelo.modeloUsuario.cedula;
                    BD.Telefono.Add(modelo.modeloTelefono2);
                }
                BD.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Debe completar toda la información necesaria.");
                return View(modelo);
            }
        }
    }
}
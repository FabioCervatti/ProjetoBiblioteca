#pragma checksum "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\Usuarios\ListarUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ed6854f7ba7f63b6216f865c6fa8aace3b940cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_ListarUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/ListarUsuarios.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ed6854f7ba7f63b6216f865c6fa8aace3b940cb", @"/Views/Usuarios/ListarUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuarios_ListarUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Usuários cadastrados no sistema</h1>\r\n\r\n<p class=\"text-danger\">");
#nullable restore
#line 5 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\Usuarios\ListarUsuarios.cshtml"
                  Write(ViewData["mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th scope=\"row\">Nome</th>\r\n\r\n      <th scope=\"row\">Login</th>\r\n\r\n      <th scope=\"row\">Tipo</th>\r\n    </tr>\r\n  </thead>\r\n\r\n  <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\Usuarios\ListarUsuarios.cshtml"
         foreach (Usuario u in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 23 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\Usuarios\ListarUsuarios.cshtml"
         Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n          <td>");
#nullable restore
#line 25 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\Usuarios\ListarUsuarios.cshtml"
         Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\Usuarios\ListarUsuarios.cshtml"
                 if (u.Tipo == Usuario.ADMIN)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("              <td>Administrador</td>\r\n");
#nullable restore
#line 31 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\Usuarios\ListarUsuarios.cshtml"

                }
                else
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("              <td>Padrão</td>\r\n");
#nullable restore
#line 37 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\Usuarios\ListarUsuarios.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          <td><a");
            BeginWriteAttribute("href", " href=\"", 671, "\"", 701, 2);
            WriteAttributeValue("", 678, "EditarUsuarios?id=", 678, 18, true);
#nullable restore
#line 40 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\Usuarios\ListarUsuarios.cshtml"
WriteAttributeValue("", 696, u.Id, 696, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\r\n\r\n          <td><a");
            BeginWriteAttribute("href", " href=\"", 738, "\"", 768, 2);
            WriteAttributeValue("", 745, "ExcluirUsuario?id=", 745, 18, true);
#nullable restore
#line 42 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\Usuarios\ListarUsuarios.cshtml"
WriteAttributeValue("", 763, u.Id, 763, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Windows\OneDrive - Etec Centro Paula Souza\SENAC EAD\Módulo B - UC02 - Documentar e realizar manutenção de aplicações web\Atividades\Atividade2\Biblioteca\Views\Usuarios\ListarUsuarios.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n\r\n<a href=\"RegistrarUsuarios\">Registrar novo usuário</a>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

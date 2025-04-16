using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using SistemaVenta.DTO;
using SistemaVenta.Model;
using System.Threading.Tasks;

namespace SistemaVenta.Utility
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            
            CreateMap<Rol, RolDTO>().ReverseMap();
            CreateMap<Menu, MenuDTO>().ReverseMap();
            CreateMap<Menu, MenuDTO>().ReverseMap();

            #region Usuario
            CreateMap<Usuario, UsuarioDTO>()
                .ForMember(destino =>
                    destino.RolDescripcion,
                    opt => opt.MapFrom(origen => origen.IdRolNavigation.Nombre)

                )
                .ForMember(destino =>
                    destino.EsActivo,
                    opt => opt.MapFrom(origen => origen.EsActivo == true ? 1 : 0)
                );
            #endregion
        }
    }
}

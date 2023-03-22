using practica2_API.Modelos.Dto;

namespace practica2_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{Id=1, Nombre="villa 1", Ocupantes=3, MetrosCuadrados=50},
            new VillaDto{Id=2, Nombre="villa 2", Ocupantes=4, MetrosCuadrados=80}
        };
    }
}

# MilesCarRental_API

El siguiente codigo atiende a la necesidad de una empresa Miles Car Rental, una empresa líder en la industria del alquiler de vehículos, busca implementar un sistema de búsqueda avanzado que permita a sus clientes encontrar vehículos disponibles de manera eficiente y precisa. Este sistema se diseñará para cumplir con los criterios específicos de búsqueda querequiere la empresa, asegurando una experiencia óptima para sus usuarios. Los vehículos disponibles se deben retornar en base a los siguientes criterios:

a. Localidad de Recogida: Los clientes podrán especificar la localidad desde donde desean recoger el vehículo. Esta información será fundamental para determinar la disponibilidad de vehículos en esa
ubicación.

b. Localidad de Devolución: Además de la localidad de recogida, los usuarios podrán indicar la localidad donde desean devolver el vehículo.Esto permitirá calcular la disponibilidad y opciones de devolución en
función de la ubicación deseada.

c. Carros Disponibles para este Mercado: El sistema tomará en cuenta tanto la localidad de recogida como la ubicación del cliente para definir el mercado correspondiente. En base a este mercado, se mostrarán únicamente los vehículos disponibles y adecuados para esa área
específica.

Para realizar las pruebas debes saber lo siguiente: 
Inicialmente, debe clonar el proyecto y accerder a la consola, para poder crear la base de datos localmente, debe tener en cuenta que en mi caso mi servidor lo llame localhost, en caso de que no lo tenga asi debe proceder a cambiar el nombre en el archivo appsettings.json. Debido a que la conexión ya esta lista. Luego de esto debe proceder a ejecutar el comando **update-database** para luego proceder a realizar las pruebas. El proyecto esta documentado con swagger

1. Localidad de Recogida, el proyecto solo tiene 5 localidades guardada usnado del 1 al 5, de lo contrara indicara que no existe la localidad
2. Localidad de Devolución, Las localidades tiene las 5 localidades 1-5, de lo contrario encontrará que no se puede realizar la devolucion en esa localidad indicada, en este caso la 3 no permite realizar devolucion. Solo por criterios de prueba
3. Carros Disponibles para este Mercado, en este caso deberas enviar la localidad que estas interesado, en este caso 1 a 5, adicionalmente latitude y longitud de la posicion del usuario, y adicionalmente se toma un parametro adicional de buscar en un radio de kilometro para listar los carros disponibles en este caso se recomienda usar los siguientes:

   LocalId=1
   Latitude= 10.4881
   logintude= -66.8795
   searchRadiusKm = 1

   LocalId=2
   Latitude= 48.8584
   logintude= 2.2930
   searchRadiusKm = 10
   
LOCALIDADES: 

Id = 1,                                  
Name= "Parque Central",

Id = 2,
Name = "Torre Central",

Id = 3,
Name = "Plaza de Bolivar",

Id = 4,
Name = "Salitre Magico",

Id = 5,
Name = "Movistar Arena"


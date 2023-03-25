source: https://www.codurance.com/es/katalyst/smart-fridge

Codurance
Clientes Servicios
 Insights
 Carreras
 Eventos Sobre nosotros
 Contáctanos
EN
ES
Smart Fridge
TDD diseño de patrones avanzado estructura de datos diseño orientado a objetos
Jordan Colgan
Jordan Colgan
See author's bio and posts



Te han contratado como desarrollador para FridgeCraft, un fabricante de neveras que se enorgullece de la calidad de sus productos.

FridgeCraft ha decidido adoptar la tendencia de fabricar una nevera "inteligente", y tu trabajo será crear el software para integrarlo en el nuevo modelo de prueba.
Instrucciones
El equipo de I+D te ha dado los siguientes requisitos que deberá tener tu programa para la primera iteración del modelo de prueba:

Monitorear los artículos que entran y salen de la nevera
Cuando se añada un artículo, la nevera debe registrar:
  - Nombre del artículo
  - Fecha de caducidad
  - Fecha en la que fue añadido
Cada vez que se abre la nevera, los artículos que están dentro reducen su caducidad en:
  - 1 hora (si está cerrada)
  - 5 horas (si está abierta)
Proporcionar un formato de visualización para ver los artículos y su caducidad en el siguiente orden:
  - Los artículos caducados deben aparecer primero como “EXPIRED: $item.name”
  - Los artículos no caducados se muestran después como "$item.name: n day(s) remaining

Es posible que tengas que establecer una manera de simular el paso de los días, para que la funcionalidad pueda demostrarse fácilmente en el modelo de prueba. Pero asegúrate de que esto no afecte a la funcionalidad principal del sistema y pueda eliminarse fácilmente para los modelos de lanzamiento.
El equipo de I+D también ha puesto a tu disposición una serie de puntos de los que no tendrás que preocuparte:

El lugar donde se colocan los artículos o qué tan llena está la nevera.
El tiempo que la nevera permanece abierta.

Limitaciones en el número de artículos que se pueden añadir.

Aunque este sea sólo un prototipo para mostrar a los stakeholders, debes tratarlo con el mismo cuidado que tendrías con un sistema real. Piensa en las decisiones que tomes y cómo estás afectarán a la extensibilidad del sistema en el futuro.

Buena suerte, y mantén la calma.

Ejemplos de eventos
Un enfoque que podrías adoptar para esta kata es el Event Sourcing.

El siguiente ejemplo es de eventos típicos realizados alrededor de tu modelo de prueba. Incluso podrías utilizarlo como una prueba de aceptación final.

> Set Current Date - "18/10/2021"

> Fridge Door Opened
> Item added - name: "Milk", expiry: "21/10/21", condition: "sealed"
> Item added - name: "Cheese", expiry: "18/11/21", condition: "sealed"
> Item added - name: "Beef", expiry: "20/10/21", condition: "sealed"
> Item added - name: "Lettuce", expiry: "22/10/21", condition: "sealed"
> Fridge Door Closed

> (Day Over)

> Fridge Door Opened
> Fridge Door Closed

> Fridge Door Opened
> Fridge Door Closed

> Fridge Door Opened
> Item removed - name: "Milk"
> Fridge Door Closed

> Fridge Door Opened
> Item added - name: "Milk", expiry: "26/10/21", condition: "opened"
> Item added - name: "Peppers", expiry: "23/10/21", condition: "opened"
> Fridge Door Closed

> (Day Over)

> Fridge Door Opened
> Item removed - name: "Beef"
> Item removed - name: "Lettuce"
> Fridge Door Closed

> Fridge Door Opened
> Item added - name: "Lettuce", expiry: "22/10/21", condition: "opened"
> Fridge Door Closed

> Fridge Door Opened
> Fridge Door Closed

> (Day Over)

Estas interacciones deberían generar la siguiente visualización en la nevera:

EXPIRED: Milk
Lettuce: 0 days remaining
Peppers: 1 day remaining
Cheese: 31 days remaining
¿Preparado para inspirarte?
Suscríbete a nuestra newsletter para que podamos hacerte llegar recomendaciones de expertos y casos prácticos inspiradores
Correo electrónico*
Related Blogs
TDD diseño de patrones avanzado estructura de datos diseño orientado a objetos
12 Days of Christmas
By Rowan Lea · Posted 03-mar-2023 14:23:41
12 Days of Christmas
El objetivo de esta kata navideña es imprimir la letra de la canción "Doce días de Navidad" con el menor número de líneas posible.

TDD testing skills developers Principiante programación
Vamos a construir un árbol de Navidad
By Tom Kellet · Posted 03-mar-2023 13:54:22
Vamos a construir un árbol de Navidad
Hay una escasez de árboles de Navidad, sin embargo, ¡tú puedes ayudar! A falta de árboles de verdad, Papá Noel va a enseñar a los niños del mundo la..

TDD testing Principiante kata programación
Stack
By Jordan Colgan · Posted 03-mar-2023 13:29:11
Stack
En informática, una pila o stack es un famoso tipo de datos abstracto que proporciona ciertas operaciones sobre una colección de elementos. Las..

Data-driven technology Principiante estructura de datos kata Diseño de algoritmos
¿Preparado para inspirarte?
Suscríbete a nuestra newsletter para que podamos hacerte llegar recomendaciones de expertos y casos prácticos inspiradores

Correo electrónico*
Software es nuestra pasión.

Somos Software Craftspeople. Construimos software bien elaborado para nuestros clientes, ayudamos a los/as desarrolladores/as a mejorar en su oficio a través de la formación, la orientación y la tutoría. Ayudamos a las empresas a mejorar en la distribución de software.

Latest Blogs
Club de lectura de Codurance: Conversaciones Difíciles
¿Estás saboteando tu business case de migración a la nube?
Circuito de Technical Coaching
¿Cómo dar buen feedback?
Useful Links
Servicios
Nuestra gente
Nuestra historia
Carreras
Política de privacidad
Política de Cookies
Suscripción a newsletter
Contáctanos
Email: hello@codurance.com

Londres
Barcelona
Manchester
Lisboa
Madrid
Málaga
Número de registro No: 8712584
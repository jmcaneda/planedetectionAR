# planedetectionAR
Detección de planos, movimiento y comportamiento de gizmo con AR en Unity
Uno de los problemas con el que nos encontramos en las experiencias AR, es lugar en el que los objetos se instancian.
Si optamos por la opción de ser la programación quien lo haga, podria darse el caso, que por limitaciones de espacio, la experiencia no sea gratificante.
Con esta experiencia practico la manera en la que puedo ubicar el objeto instanciado, en el lugar deseado.
El proceso es el siguiente, se detectan los planos y si Raycast es exitoso, situo el grid en uno de ellos.
El grid lo puedo desplazar por los diferentes planos, siguiendo los Raycast sucesivos.
Con un click o tap, instancio el objeto, en esta ocasión un gizmo. Este sigue al grid o rota si el grid permanece inmovil.
Con doble click o doble tap, fijo al gizmo en el lugar y orientación deseada.
De esta forma he podido fijar el portal en M-ART Soho, a la distancia adecuada, para una mejor experiencia AR.
Veámoslo en vivo, desde el vidio promoción <a href="https://youtu.be/Wh_YoU_aExg" target="_blank"> https://youtu.be/Wh_YoU_aExg</a>

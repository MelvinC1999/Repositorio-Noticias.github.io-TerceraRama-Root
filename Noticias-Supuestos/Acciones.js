window.addEventListener('scroll', function(){

function fade(direccion){

    var imagen = document.querySelectorAll('.fade_'+direccion); /*Esto es un arreglo que conseguimos con el metodo*/ 

    for(var i = 0; i < imagen.length; i++){     //Recorremo el array
    
        var altura = window.innerHeight/1.3;
        var distancia = imagen[i].getBoundingClientRect().top;

        console.log(altura)
        console.log(distancia)

        imagen[i].classList.add('transform_'+direccion);

        if(distancia <= altura){
            imagen[i].classList.add('aparece');
        }else{
            imagen[i].classList.remove('aparece');
        }
    }    
}    
    fade('up')
    fade('down')
    fade('right')
    fade('left')
})
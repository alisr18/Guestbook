let resultat = document.getElementById("display");

let calculate=(number)=>{
    resultat.value += number;
}

function Reset(){
    resultat.value = ""
}

function clr(){
    resultat.value = resultat.value.slice(0,-1)
}

let Result=()=>{
    try {
        
        resultat.value = eval(resultat.value)
        if (resultat.value === "undefined"){
            resultat.value = "noice"
        }
    }
    catch(err){
        if("+-" in resultat.value){
            resultat.value -= "+"
            resultat.value = eval(resultat.value)
        }
        else if ("-+" in resultat.value){
            resultat.value -= "-"
            resultat.value = eval(resultat.value)
        }
    }
    console.log(resultat.value)
}


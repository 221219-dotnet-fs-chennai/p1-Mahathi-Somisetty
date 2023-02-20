function Ueducation(){
    const f1 = document.getElementById("forms");
    f1.addEventListener("submit",event =>{
        event.preventDefault();
    });

    let user = document.getElementById("uid").value
    let Hq = document.getElementById("hq").value
    let year = document.getElementById("yp").value
    let percentage =document.getElementById("percent").value
    let str = document.getElementById("stream").value

    fetch(`https://localhost:7256/api/T/updateEducation?id=${user}`,{
        method:'PUT',
        body:JSON.stringify({
         traineeId:user,
         hQualification:Hq,
         yearOfPassing: year,
         percentage:percentage,
         stream:str,
        }),
        headers:{
            "Content-type":"application/json;charset=UTF-8",
        },
    })
    .then((Response)=>{
        if(Response.status === 200){
            alert("updated successfully");
            window.location.href="profile.html";
        }
        else{
            alert("try again");
        }

    })
}
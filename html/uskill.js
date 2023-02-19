function uskill(){
    let user = document.getElementById("uid").value
    let Sname = document.getElementById("sname").value
    let Stype = document.getElementById("stype").value
    let Expertise=document.getElementById("expertise").value

    fetch(`https://localhost:7256/api/T/updateskilldetails?Id=${user}`,{
        method:"PUT",
        body:JSON.stringify({
            traineeId:user,
            skill_name:Sname,
            skill_Type:Stype,
            expertise:Expertise
        }),
        headers:{
            "Content-type":"application/json;charset=UTF-8",
        },
    })
    .then((Response)=>{
        if(Response.status===200){
            alert("updated successfully");
            window.location.href="profile.html";
        }
    })
}
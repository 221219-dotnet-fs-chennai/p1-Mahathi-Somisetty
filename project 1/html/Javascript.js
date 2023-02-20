// for all details
// function Alldetails() {
    fetch('https://localhost:7256/api/T/GetAllDetails')
        .then(Response => Response.json())
        
        .then(data => data.forEach(user => {
            const markup = `<ol>
    <h4>Trainee Details</h4>
    <h6><i>personal Details</i></h6>
    Name : ${user.fullName}<br>
    EmailID:${user.emailId}<br>
    Gender:${user.gender}<br>
    Age:${user.age}<br>
    PhoneNumber:${user.phoneNumber}
    <h6><i>Educational Details</i></h6>
    HighestQualification:${user.hQualification}<br>
    YearOfPassing:${user.yearOfPassing}<br>
    Percentage:${user.percentage}<br>
    Stream:${user.stream}<br>
    <h6>Company Details</h6>
    Companyname:${user.company_name}<br>
    Positon:${user.position}<br>
    Experience:${user.experience}
    <h6>Skill Details</h6>
    Skill Name:${user.skill_name}<br>
    Skill_Type:${user.skill_Type}<br>
    experience:${user.expertise}

    </ol>`

            document.querySelector("ol").insertAdjacentHTML('beforeend', markup);
        }))



// function Adddetails() {
//     fetch('https://localhost:7256/api/T/ADDTraineeDetails')
//         .then(Response => Response.json())
//         .then(data => data.foreach(element => {
//             const markup = `<ol>
//         <h4>add details</h4>
//         Name : ${user.fullName}<br>
//         EmailID:${user.emailId}<br>
//         Gender:${user.gender}<br>
//         Age:${user.age}<br>
//         PhoneNumber:${user.phoneNumber}
//         </ol>`
//             document.querySelector("ol").insertAdjacentHTML('beforeend', data);

//         }))
// }




// Alldetails();
//trainer details



//login
function login() {
    document.getElementById("log").addEventListener('submit', function (event) {
        event.preventDefault();
        var email = document.getElementById('email').value;
        var psw = document.getElementById('psw').value;
        fetch(`https://localhost:7256/api/T/Login/validate?email=${email}&psw=${psw}`, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'email': email,
                'pass': psw
            }
        }).then(response => {
                if (response.status === 200) {
                    alert('Login Success');
                    window.location.href='view.html';
                }
                else {
                    alert('login fail');
                }
            })
            

    });

}


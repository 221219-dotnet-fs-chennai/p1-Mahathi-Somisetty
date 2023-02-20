function login() {
    document.getElementById("log").addEventListener('submit', function (event) {
        event.preventDefault();
        var email = document.getElementById('email').value;
        var psw = document.getElementById('psw').value;
        console.log(email,psw);
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


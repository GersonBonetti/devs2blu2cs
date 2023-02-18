<!DOCTYPE html>
<html lang="pt_BR">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous">
    <link rel="icon" href="img/logo.png">
    <title>Login - Estoque</title>
    

    <style>

        @import url('https://fonts.googleapis.com/css2?family=Ubuntu:wght@300&display=swap');

        body
        {
            font-family: 'Ubuntu', sans-serif;
            background: #161A1D;
            background-color: linear-gradient(to right, #242423, #333533);
        }

        .bg-gabs
        {
            background: #0B090A;
        }

        .my-3 
        {
            outline: none;
        }

        .mb-4
        {
            color: #FFFFFF;
        }

        .btn-primary
        {
            background-color: transparent;
            color: #FFFFFF;
            border-color: #FFFFFF;
        }

        .btn-primary:hover
        {
            background-color: #E5383B;
            color: #fff;
            border-color: #E5383B;
        }

      </style>  
</head>
    <body>
        
        <div class="container mt-5 w-75 bg-gabs-primary rounded shadow">
            <div class="row align-items-stretch justify-content-center">
                <div class="col bg-white d-none d-lg-block col-md-5 col-lg-5 col-xl-6 rounded-start-5">
                  <h2 class="title-description fw-bold text-black text-center justify-content-center m-5 fw-bold">Olá, novamente!</h2>
                  <h4 class="description-paragraph text-black-50 text-center justify-content-center">Utilizamos esse portal, para filtrar quem tem acesso a nossa plataforma de estoque!</h4>
                  <img src="img/description.svg" alt="YF Automação / Storyset" class="description-img">
                    
                </div>
                <div class="col bg-gabs p-5 mx rounded-end-5">
                    <div class="text-end">
                        <img src="img/logo.png" width="55" alt="">
                    </div>

                    <h2 class="fw-bold text-white text-center py-5">Efetue seu login aqui</h2>

                    <!-- Login -->

                    <form action="#">
                        <div class="mb-4">
                            <label for="user" class="form-label">Usuário</label>
                            <input type="user" class="form-control" name="user" placeholder="Usuario">
                        </div>
                        <div class="mb-4">
                            <label for="password" class="form-label">Senha</label>
                            <input type="password" class="form-control" name="password" placeholder="*******">
                        </div>
                        
                        <div class="mb-4 form-check">
                            <input type="checkbox" name="connect" class="form-check-input" id="">
                            <label for="connect" class="form-check-label">Manter acesso</label>
                        </div>

                        <div class="d-grid">
                            <button type="submit" class="btn btn-primary fw-bold">L O G I N</button>
                        </div>

                        <div class="my-4 text-center">
                            <h6><a href="">Recuperar senha</a></h6>
                        </div>

                    </form>

                </div>
            </div>
        </div>


        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
    </body>
</html>
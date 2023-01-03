



<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html lang="en">

    <head>

        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
        <meta name="description" content="">
        <meta name="author" content="">

        <title>Shop Homepage - Start Bootstrap Template</title>

        <!-- Bootstrap core CSS -->
        <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

        <!-- Custom styles for this template -->
        <link href="css/shop-homepage.css" rel="stylesheet">

    </head>

    <body>
            <section class="vh-95">
                <div class="container py-5 h-100">
                    <div class="row d-flex align-items-center justify-content-center h-100">
                        <div class="col-md-8 col-lg-7 col-xl-6">
                            <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.svg" class="img-fluid" alt="Phone image">
                        </div>
                        <div class="col-md-7 col-lg-5 col-xl-5 offset-xl-1">
                            <form action="login" method="post">
                                <h1 style="text-align: center ; margin-bottom: 46px">Login as User</h1>
                                <!-- user input -->
                                <h3 style="color: green">${success} </h3>
                                <div class="form-outline mb-4">
                                    <input name="username" type="text" id="username" class="form-control form-control-lg" />
                                    <label class="form-label" for="username">Username</label>
                                </div>

                                <!-- Password input -->
                                <div class="form-outline mb-4">
                                    <input name="password" type="password" id="password" class="form-control form-control-lg" />
                                    <label class="form-label" for="password">Password</label>
                                </div>

                                <div class="d-flex justify-content-around align-items-center mb-4">
                                    <!-- Checkbox -->
                                    <div style="margin-right: 300px" lass="form-check">
                                        <input name="remember"
                                               class="form-check-input"
                                               type="checkbox"
                                               value=""
                                               id="form1Example3"                                          
                                               />
                                        <label class="form-check-label" for="form1Example3"> Remember me </label>
                                    </div>
                                </div>

                                <h3 class="text-danger">${error}</h3>
                                <!-- Submit button -->
                                <button type="submit" class="btn btn-primary btn-lg btn-block">Sign in</button>
                            </form>
                            <div class="divider d-flex align-items-center my-4">
                                <p class="text-center fw-bold mx-3 mb-0 text-muted">OR</p>
                            </div>

                            <a class="btn btn-primary btn-lg btn-block" style="background-color: #3b5998" href="register" role="button">
                                <i class="me-2"></i>Register
                            </a> 
                        </div>
                    </div>
                </div>
            </section>


        <!-- Bootstrap core JavaScript -->
        <script src="vendor/jquery/jquery.min.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    </body>

</html>



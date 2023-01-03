



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

    <body style="background-color: black">
            <section class="vh-95">
                <div class="container py-5 h-100">
                    <div class="row d-flex align-items-center justify-content-center h-100">
                        <div class="col-md-8 col-lg-7 col-xl-6">
                            <img src="https://previews.123rf.com/images/christitze/christitze1611/christitze161121058/65369777-admin-gold-text-on-black-background-3d-rendered-royalty-free-stock-picture-this-image-can-be-used-fo.jpg" class="img-fluid" alt="Phone image">
                        </div>
                        <div class="col-md-7 col-lg-5 col-xl-5 offset-xl-1">
                            <form action="adlogin" method="post">
                                <h1 style="text-align: center ; margin-bottom: 46px ; color: white" >Login as ADMIN</h1>
                                <!-- user input -->
                                <h3 style="color: green">${success} </h3>
                                <div class="form-outline mb-4">
                                    <input name="username" type="text" id="username" class="form-control form-control-lg " />
                                    <label class="form-label" for="username" style="color: white">Username</label>
                                </div>

                                <!-- Password input -->
                                <div class="form-outline mb-4">
                                    <input name="password" type="password" id="password" class="form-control form-control-lg" />
                                    <label class="form-label" for="password" style="color: white">Password</label>
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
                                        <label class="form-check-label" for="form1Example3" style="color: red"> Remember me </label>
                                    </div>
                                </div>

                                <h3 class="text-danger">${error}</h3>
                                <!-- Submit button -->
                                <button type="submit" class="btn btn-primary btn-lg btn-block" style="background-color: black ; color:  cyan">Sign in</button>
                            </form>
                        </div>
                    </div>
                </div>
            </section>


        <!-- Bootstrap core JavaScript -->
        <script src="vendor/jquery/jquery.min.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    </body>

</html>



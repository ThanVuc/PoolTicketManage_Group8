<template>
    <div class="container mt-5 d-flex justify-content-center align-items-center">
        <div class="card mb-0" style="width: 400px;">
            <div class="card-body">
                <h4 class="card-title mb-1 text-center">Login</h4>
                <div class="auth-login-form mt-2">
                    <div class="mb-1">
                        <label class="form-label">Email</label>
                        <input v-model="tai_khoan.email" type="text" class="form-control" placeholder="john@example.com">
                    </div>

                    <div class="mb-1">
                        <div class="d-flex justify-content-between">
                            <label class="form-label" for="login-password">Password</label>
                            <a href="">
                                <small>Forgot Password?</small>
                            </a>
                        </div>
                        <div class="input-group input-group-merge form-password-toggle">
                            <input v-model="tai_khoan.password" type="password" class="form-control form-control-merge" placeholder="············">
                        </div>
                    </div>
                    <div class="mb-1">
                        <div class="form-check">
                            <input class="form-check-input" type="checkbox" id="remember-me" tabindex="3">
                            <label class="form-check-label" for="remember-me"> Remember Me </label>
                        </div>
                    </div>
                    <button v-on:click="dangNhap()" class="btn btn-primary w-100 waves-effect waves-float waves-light" tabindex="4">Sign
                        in</button>
                    </div>

                <p class="text-center mt-2">
                    <span>New on our platform?</span>
                    <router-link to="/khach-hang/dang-ky">
                        <a href="/khach-hang/dang-ky">
                        <span>Create an account</span>
                    </a>
                    </router-link>
                </p>
            </div>
        </div>
    </div>
</template>
<script>
import axios from 'axios';

export default {
    data() {
        return {
            tai_khoan : {}
        }
    },
    methods: {
        dangNhap(){
            axios
                .post("http://127.0.0.1:8000/api/khach-hang/dang-nhap", this.tai_khoan)
                .then((res) => {
                    if(res.data.status){
                        this.$toast.success(res.data.message);
                        localStorage.setItem('token_khach_hang', res.data.token);
                        this.$router.push("/trang-chu")
                    } else {
                        this.$toast.error(res.data.message);
                    }
                });
        }
    },
}
</script>
<style></style>
<template>
    <div class="container">
        <div class="card mb-0" style="width: 500px;">
            <div class="card-body">
                <h2 class="brand-text text-primary ms-1 text-center">Đăng Ký</h2>
                <form class="auth-register-form mt-2">
                    <div class="mb-1">
                        <label for="register-username" class="form-label">Username</label>
                        <input v-model="tai_khoan.username" type="text" class="form-control" id="register-username"
                            placeholder="johndoe" tabindex="1" autofocus="">
                    </div>
                    <div class="mb-1">
                        <label for="register-email" class="form-label">Email</label>
                        <input v-model="tai_khoan.email" type="text" class="form-control" placeholder="john@example.com"
                            tabindex="2">
                    </div>
                    <div class="mb-1">
                        <label for="register-password" class="form-label">Password</label>
                        <div class="input-group input-group-merge form-password-toggle">
                            <input v-model="tai_khoan.password" type="password" class="form-control form-control-merge"
                                placeholder="············" tabindex="3">
                        </div>
                    </div>
                    <div class="mb-1">
                        <div class="form-check">
                            <input class="form-check-input" type="checkbox" id="register-privacy-policy" tabindex="4">
                            <label class="form-check-label" for="register-privacy-policy">
                                I agree to <a href="#">privacy policy &amp; terms</a>
                            </label>
                        </div>
                    </div>
                </form>
                <button v-on:click="dangKy()" class="btn btn-primary w-100" tabindex="5">Sign
                    up</button>
            </div>
        </div>
    </div>
</template>
<script>
import axios from 'axios';

export default {
    data() {
        return {
            tai_khoan: {},
        }
    },
    methods: {
        
        dangKy() {
            axios
                .post("http://127.0.0.1:8000/api/khach-hang/dang-ky", this.tai_khoan)
                .then((res) => {
                    if (res.data.status){
                        this.$toast.success(res.data.message);
                        this.$router.push("/khach-hang/dang-nhap")
                    }
                    else this.$toast.error(res.data.message)
                });
            }
    },
}
</script>
<style>
.container {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    /* Chiều cao 100% của màn hình */
}
</style>
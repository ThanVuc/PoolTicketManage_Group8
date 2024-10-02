<template>
    <div class="container mt-2">
        <div class="card">
            <div class="row g-0">
                <div class="col-md-4 border-end">
                    <img v-bind:src="chi_tiet_ve.hinh_anh" class="img-fluid w-100">
                    <div class="row mb-3 row-cols-auto g-2 justify-content-center mt-3">
                        <div class="col"><img src="assets/images/products/12.png" width="70"
                                class="border rounded cursor-pointer" alt=""></div>
                        <div class="col"><img src="assets/images/products/11.png" width="70"
                                class="border rounded cursor-pointer" alt=""></div>
                        <div class="col"><img src="assets/images/products/14.png" width="70"
                                class="border rounded cursor-pointer" alt=""></div>
                        <div class="col"><img src="assets/images/products/15.png" width="70"
                                class="border rounded cursor-pointer" alt=""></div>
                    </div>
                </div>
                <div class="col-md-8">
                    <div class="card-body">
                        <h4 class="card-title">Giá hồ bơi đối với
                            <span v-if="chi_tiet_ve.doi_tuong == 0">Trẻ Em</span>
                            <span v-else-if="chi_tiet_ve.doi_tuong == 1">Người Lớn</span>
                            <span v-else>Sinh Viên</span>
                        </h4>
                        <div class="d-flex gap-3 py-3">
                            <div class="cursor-pointer">
                                <i class="bx bxs-star text-warning"></i>
                                <i class="bx bxs-star text-warning"></i>
                                <i class="bx bxs-star text-warning"></i>
                                <i class="bx bxs-star text-warning"></i>
                                <i class="bx bxs-star text-secondary"></i>
                            </div>
                            <div>142 reviews</div>
                        </div>
                        <div class="mb-3">
                            <span class="price h4">{{ chi_tiet_ve.gia_khuyen_mai }} VND</span>
                            <b>
                                <span class="text-muted">/
                                    <span v-if="chi_tiet_ve.loai_ve == 0">Ngày</span>
                                    <span v-else>Tháng</span>
                                </span>
                            </b>
                        </div>

                        <div class="row row-cols-auto row-cols-1 row-cols-md-3 align-items-center">
                            <div class="col">
                                <label class="form-label">Số Lượng</label>
                                <div class="input-group input-spinner">
                                    <button v-on:click="cong()" class="btn btn-white" type="button"> + </button>
                                    <input v-model="so_luong" type="number" class="form-control">
                                    <button v-on:click="tru()" class="btn btn-white" type="button"> − </button>
                                </div>
                            </div>
                            <div class="col">
                                <div class="color-indigators d-flex align-items-center gap-2">
                                    <div class="color-indigator-item bg-primary"></div>
                                    <div class="color-indigator-item bg-danger"></div>
                                    <div class="color-indigator-item bg-success"></div>
                                    <div class="color-indigator-item bg-warning"></div>
                                </div>
                            </div>
                        </div>
                        <router-link :to="'/khach-hang/thanh-toan/' +chi_tiet_ve.id">
                            <div class="d-flex gap-3 mt-3">
                                <button v-on:click="thanhToan()" class="btn btn-primary">Mua Ngay</button>
                            </div>
                        </router-link>
                    </div>
                </div>
            </div>
            <hr>
        </div>
    </div>
</template>
<script>
import axios from 'axios';

export default {
    props: ["id_ve"],
    data() {
        return {
            chi_tiet_ve: {},
            id_ve: this.$route.params.id_ve,
            so_luong: 1
        }
    },
    mounted() {
        this.laythongtin();
    },
    methods: {
        laythongtin() {
            axios
                .get("http://127.0.0.1:8000/api/chi-tiet/" + this.id_ve)
                .then((res) => {
                    this.chi_tiet_ve = res.data.data;
                });
        },
        thanhToan() {
            var payload = {
                "id_ve": this.id_ve,
                "doi_tuong": this.chi_tiet_ve.doi_tuong,
                "gia_ban": this.chi_tiet_ve.gia_ban,
                "gia_khuyen_mai": this.chi_tiet_ve.gia_khuyen_mai,
                "hinh_anh": this.chi_tiet_ve.hinh_anh,
                "loai_ve": this.chi_tiet_ve.loai_ve,
                "so_luong": this.so_luong
            };
            axios
                .post("http://127.0.0.1:8000/api/khach-hang/thanh-toan", payload, {
                    headers: {
                        Authorization: 'Bearer ' + localStorage.getItem("token_khach_hang")
                    }
                })
                .then((res) => {
                    if (res.data.status) {
                        this.$toast.success(res.data.message);
                    } else {
                        this.$toast.error(res.data.message);
                    }
                });
        },
        cong() {
            this.so_luong += 1;
        },
        tru() {
            if (this.so_luong > 1) {
                this.so_luong -= 1;
            } else {
                var thongbao = "Số lượng phải lớn hơn 0";
                this.$toast.warning(thongbao);
            }
        }
    }
}
</script>
<style></style>
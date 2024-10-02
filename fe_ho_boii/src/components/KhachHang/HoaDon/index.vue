<template>
    <div class="container d-flex justify-content-center">
        <div class="row">
            <div class="col-lg-12">
                <div class="card">
                    <div class="card-header">
                        <img src="https://tse2.mm.bing.net/th?id=OIP.-UOUT22rz3P5SGjRfS1TigHaEE&pid=Api&P=0&h=220"
                            class="img-fluid">
                        <h2 class="mt-3 text-center">Thông Tin Hóa Đơn</h2>
                    </div>
                    <div class="card-body">
                        <p><b>Mã Hóa Đơn:</b> HD00{{ chi_tiet_hoa_don.id}}</p>
                        <p><b>Trung Tâm Hồ Bơi:</b> Huycoder</p>
                        <p><b>Khách Hàng:</b> {{ chi_tiet_hoa_don.username }}</p>
                        <div class="row">
                            <div class="col-lg-12 text-center">
                                <h2>Chi Tiết Hóa Đơn</h2>
                                <table class="table table-bordred">
                                    <thead>
                                        <tr>
                                            <th>Tên Sản Phẩm</th>
                                            <th class="text-center">SL</th>
                                            <th class="text-center">Đơn giá</th>
                                            <th class="text-center">Thành tiền</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>Vé 
                                                <span v-if="chi_tiet_hoa_don.doi_tuong == 0">Trẻ Em</span>
                                                <span v-else-if="chi_tiet_hoa_don.doi_tuong">Người Lớn</span>
                                                <span v-else>Sinh Viên</span>
                                            </td>
                                            <td class="text-center">{{ chi_tiet_hoa_don.so_luong }}</td>
                                            <td class="text-center">{{ chi_tiet_hoa_don.gia_khuyen_mai }} đ</td>
                                            <td class="text-center">{{ chi_tiet_hoa_don.gia_khuyen_mai * chi_tiet_hoa_don.so_luong }} đ</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <p class="text-center">Cảm ơn quý khách</p>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
import axios from 'axios';

export default {
props: ["id"],
data() {
    return {
        id_ve : this.$route.params.id,
        chi_tiet_hoa_don : {}
        }
    },
    mounted() {
        this.laythongtin();
    },
    methods: {
        laythongtin() {
            var id_ve = {
                "id"    : this.id_ve
            };
            axios
                .post("http://127.0.0.1:8000/api/khach-hang/chi-tiet-hoa-don", id_ve)
                .then((res) => {
                    if(res.data.status){
                        this.chi_tiet_hoa_don = res.data.data;
                        console.log(this.chi_tiet_hoa_don);
                    }
                    else {
                        console.log(res.data.message);
                    }
                });
        },
    },
}
</script>
<style></style>
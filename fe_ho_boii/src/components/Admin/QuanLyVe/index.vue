<template>
    <div class="container">
        <div class="row">
            <div class="col-lg-3">
                <div class="card">
                    <div class="card-header">
                        <h4>Thêm Mới Vé</h4>
                    </div>
                    <div class="card-body">
                        <div class="mb-2">
                            <label>Đối Tượng</label>
                            <select v-model="create_ve.doi_tuong" class="form-control">
                                <option value="0">Trẻ Em</option>
                                <option value="1">Người Lớn</option>
                                <option value="2">Sinh Viên</option>
                            </select>
                        </div>
                        <div class="mb-2">
                            <label>Loại Vé</label>
                            <select v-model="create_ve.loai_ve" class="form-control">
                                <option value="0">Ngày</option>
                                <option value="1">Tháng</option>
                            </select>
                        </div>
                        <div class="mb-2">
                            <label>Giá Bán</label>
                            <input v-model="create_ve.gia_ban" type="number" class="form-control">
                        </div>
                        <div class="mb-2">
                                <label>Giá Khuyến Mãi</label>
                                <input v-model="create_ve.gia_khuyen_mai" type="number" class="form-control">
                        </div>
                        <div class="mb-2">
                                <label>Hình Ảnh</label>
                                <input v-model="create_ve.hinh_anh" type="text" class="form-control">
                        </div>
                    </div>
                    <div class="card-footer text-end">
                        <button v-on:click="themMoi()" class="btn btn-primary">Thêm</button>
                    </div>
                </div>
            </div>
            <!-- Modal -->
            <div class="modal fade" id="updateModal" tabindex="-1" aria-labelledby="exampleModalLabel"
                aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h1 class="modal-title fs-5" id="exampleModalLabel">Cập Nhật</h1>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body">
                            <div class="mb-2">
                                <label>Đối Tượng</label>
                                <select v-model="edit_ve.doi_tuong" class="form-control">
                                    <option value="0">Trẻ Em</option>
                                    <option value="1">Người Lớn</option>
                                    <option value="2">Sinh Viên</option>
                                </select>
                            </div>
                            <div class="mb-2">
                                <label>Loại Vé</label>
                                <select v-model="edit_ve.loai_ve" class="form-control">
                                    <option value="0">Ngày</option>
                                    <option value="1">Tháng</option>
                                </select>
                            </div>
                            <div class="mb-2">
                                <label>Giá Bán</label>
                                <input v-model="edit_ve.gia_ban" type="number" class="form-control">
                            </div>
                            <div class="mb-2">
                                <label>Giá Khuyến Mãi</label>
                                <input v-model="edit_ve.gia_khuyen_mai" type="number" class="form-control">
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                            <button v-on:click="updateVe()" data-bs-dismiss="modal" type="button" class="btn btn-primary">Save changes</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-9 mx-auto">
                <div class="card">
                    <div class="card-header">
                        <h4 class="text-center">Danh Sách Các Loại Vé</h4>
                    </div>
                    <div class="card-body">
                        <div class="table-responsive">
                            <table class="table table-bordered table-hover">
                                <thead>
                                    <tr>
                                        <th class="text-center align-middle">#</th>
                                        <th class="text-center align-middle">Hình Ảnh</th>
                                        <th class="text-center align-middle">Loại Vé</th>
                                        <th class="text-center align-middle">Đối Tượng</th>
                                        <th class="text-center align-middle">Giá Bán</th>
                                        <th class="text-center align-middle">Giá Khuyến Mãi</th>
                                        <th class="text-center align-middle">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <template v-for="(value, index) in list_ve" :key="index">
                                        <tr>
                                            <td class="text-center align-middle">{{ index + 1 }}</td>
                                            <td class="text-center align-middle">
                                                <img v-bind:src="value.hinh_anh" class="img-fluid"
                                                    style="width: 100px;">
                                            </td>
                                            <td class="text-center align-middle">
                                                <button v-if="value.loai_ve == 0" v-on:click="doiLoaiVe(value)"
                                                    class="btn btn-success">Ngày</button>
                                                <button v-else v-on:click="doiLoaiVe(value)"
                                                    class="btn btn-primary">Tháng</button>
                                            </td>
                                            <td class="text-center align-middle">
                                                <span>{{ getDoiTuongText(value.doi_tuong) }}</span>
                                            </td>
                                            <td class="text-center align-middle">{{ value.gia_ban }}</td>
                                            <td class="text-center align-middle">{{ value.gia_khuyen_mai }}</td>
                                            <td class="text-center align-middle">

                                                <button v-on:click="Object.assign(edit_ve, value)" class="btn btn-primary me-1" data-bs-toggle="modal"
                                                    data-bs-target="#updateModal"><i
                                                        class="fa-solid fa-pen-to-square"></i></button>
                                                <button v-on:click="deleteVe(value)"  class="btn btn-danger"><i
                                                        class="fa-solid fa-trash ms-1"></i></button>
                                            </td>
                                        </tr>
                                    </template>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</template>
<script>
import axios from 'axios';

export default {
    data() {
        return {
            list_ve     : [],
            create_ve   : {},
            edit_ve     : {}
        }
    },
    mounted() {
        this.getData();
    },
    methods: {
        getData() {
            axios
                .get("http://127.0.0.1:8000/api/ve/get-data")
                .then((res) => {
                    var list = res.data.data;
                    this.list_ve = list;
                });
        },
        doiLoaiVe(payload) {
            axios
                .post("http://127.0.0.1:8000/api/admin/doi-loai-ve", payload)
                .then((res) => {
                    this.$toast.success(res.data.message);
                    this.getData();
                });
        },
        themMoi(){
            axios
                .post("http://127.0.0.1:8000/api/admin/them-ve", this.create_ve)
                .then((res) => {
                    this.$toast.success(res.data.message);
                    this.getData();
                });
        },
        getDoiTuongText(value){
            switch (value){
                case 0: 
                    return "Trẻ em"
                case 1:
                    return "Người Lớn"
                case 2:
                    return "Sinh Viên"
            }

        },
        deleteVe(value){
            axios
                .post("http://127.0.0.1:8000/api/admin/xoa-ve", value)
                .then((res) => {
                    if(res.data.status){
                        this.$toast.success(res.data.message);
                        this.getData();
                    } else{
                        this.$toast.error(res.data.message);
                    }
                });
        },
        updateVe(){
            axios
                .post("http://127.0.0.1:8000/api/admin/update-ve", this.edit_ve)
                .then((res) => {
                    if(res.data.status){
                        this.$toast.success(res.data.message);
                        this.getData();
                    }
                });
        }

    },
}
</script>
<style>
h1 {
    font-family: "Ma Shan Zheng", cursive;
    font-weight: 400;
    font-style: normal;
    color: rgb(10, 144, 233);
}
</style>
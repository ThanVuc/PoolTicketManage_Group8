<template>
    <div class="row">
        <div id="carouselExampleIndicators" class="carousel slide">
            <div class="carousel-indicators">
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active"
                    aria-current="true" aria-label="Slide 1"></button>
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1"
                    aria-label="Slide 2"></button>
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2"
                    aria-label="Slide 3"></button>
            </div>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="https://watermark.lovepik.com/photo/20211201/large/lovepik-beauty-swimming-picture_501349694.jpg" class="d-block w-100"
                        alt="...">
                </div>
                <div class="carousel-item">
                    <img src="https://tecwood.com.vn/upload/be-boi-vo-cuc-1.jpg" class="d-block w-100"
                        alt="...">
                </div>
                <div class="carousel-item">
                    <img src="https://mytourcdn.com/upload_images/Image/Location/17_8_2016/11/ho-boi-view-bien-mytour-1.jpg"
                        class="d-block w-100" alt="...">
                </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators"
                data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators"
                data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>
    </div>
    <div class="container mt-5">
        <div class="row d-flex justify-content-between">
            <div class="bottom-right">
                <div class="title">
                    <h2 class="title title-bottom"><a href="https://pavilionhotel.vn/tin-tuc"><span>Giá Hồ Bơi Theo
                                Ngày</span></a>
                    </h2>
                </div>
                <div class="f-space30"></div>
                <p class="detail homme"><a class="title" href="https://pavilionhotel.vn/tin-tuc">Xem thêm</a></p>
            </div>
            <template v-for="(value, index) in list_ve_ngay" :key="index">
                <div class="col-lg-4">
                    <router-link :to="'/chi-tiet/'+value.id">
                        <img v-bind:src=value.hinh_anh style="width: 350px; height: 200px;" class="img-fluid">
                        <h4 class="mt-2">
                            <span v-if="value.doi_tuong == 0">Trẻ Em</span>
                            <span v-else-if="value.doi_tuong == 1">Người Lớn</span>
                            <span v-else>Sinh Viên</span>
                        </h4>
                        <div class="clearfix">
                            <p class="mb-0 float-start"><strong>134</strong> Sales</p>
                            <p class="mb-0 float-end fw-bold"><span
                                    class="me-2 text-decoration-line-through text-secondary">{{ value.gia_ban
                                    }}</span><span>{{ value.gia_khuyen_mai }}</span>
                            </p>
                        </div>
                    </router-link>
                </div>
            </template>
        </div>
    </div>
    <div class="container mt-5">
        <div class="row d-flex justify-content-between">
            <div class="bottom-right">
                <div class="title">
                    <h2 class="title title-bottom"><a href="https://pavilionhotel.vn/tin-tuc"><span>Giá Hồ Bơi Theo
                                Tháng</span></a>
                    </h2>
                </div>
                <div class="f-space30"></div>
                <p class="detail homme"><a class="title" href="">Xem thêm</a></p>
            </div>
            <template v-for="(value, index) in list_ve_thang" :key="index">
                <div class="col-lg-4">
                    <router-link :to="'/chi-tiet/' + value.id">
                        <img v-bind:src=value.hinh_anh style="width: 350px; height: 200px;" class="img-fluid">
                        <h4 class="mt-2">
                            <span v-if="value.doi_tuong == 0">Trẻ Em</span>
                            <span v-else-if="value.doi_tuong == 1">Người Lớn</span>
                            <span v-else>Sinh Viên</span>
                        </h4>
                        <div class="clearfix">
                            <p class="mb-0 float-start"><strong>134</strong> Sales</p>
                            <p class="mb-0 float-end fw-bold"><span
                                    class="me-2 text-decoration-line-through text-secondary">{{ value.gia_ban }}
                                    VND</span><span>{{ value.gia_khuyen_mai }}
                                    VND</span></p>
                        </div>
                    </router-link>
                </div>
            </template>
        </div>
    </div>
    <div class="row mt-5">
        <div id="carouselExampleIndicators" class="carousel slide">
            <div class="carousel-indicators">
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active"
                    aria-current="true" aria-label="Slide 1"></button>
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1"
                    aria-label="Slide 2"></button>
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2"
                    aria-label="Slide 3"></button>
            </div>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="https://dayboi.vn/wp-content/uploads/2018/11/banner-3.jpg" class="d-block w-100"
                        alt="...">
                </div>
                <div class="carousel-item">
                    <img src="https://dayboi.vn/wp-content/uploads/2018/11/banner-02.jpg" class="d-block w-100"
                        alt="...">
                </div>
                <div class="carousel-item">
                    <img src="https://saigonpoolspa.com/wp-content/uploads/2022/10/thiet-ke-tong-quan-ho-boi-thanh-tam.jpg"
                        class="d-block w-100" alt="...">
                </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators"
                data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators"
                data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>
    </div>
    <div class="container mt-5">
        <div class="row d-flex justify-content-between">
            <div class="bottom-right">
                <div class="title">
                    <h2 class="title title-bottom"><a href=""><span>TIN TỨC</span></a>
                    </h2>
                </div>

                <div class="f-space30"></div>
                <p class="detail homme"><a class="title" href="">Xem thêm</a></p>
            </div>
            <div class="col-lg-4">
                <img src="https://saigonpoolspa.com/wp-content/uploads/2022/10/thiet-ke-tong-quan-ho-boi-thanh-tam.jpg"
                    style="width: 350px; height: 200px;" class="img-fluid">
                <h4 class="mt-2">Top hồ bơi gần cầu Rồng Đà Nẵng được đánh giá cao</h4>
                <p>Hồ bơi là một không gian được thiết kế để chứa nước, thường được sử dụng cho việc bơi lội, thể thao
                    dưới nước, hoặc thư giãn.</p>
            </div>
            <div class="col-lg-4">
                <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTVInZ5h85kOinsZ_6L8DBDg6u0igj3OIdFsQ&s"
                    style="width: 350px; height: 200px;" class="img-fluid">
                <h4 class="mt-2">Hồ bơi có nhiều kích thước khác nhau</h4>
                <p>Từ hồ bơi nhỏ tại các gia đình cho đến những hồ bơi lớn tại các khu thể thao và khu nghỉ dưỡng.</p>
            </div>
            <div class="col-lg-4">
                <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT1YRKIJ2plOxhLU1SzUkTIerQYizR4HmF0hg&s"
                    style="width: 350px; height: 200px;" class="img-fluid">
                <h4 class="mt-2">Nước được xử lý rất sạch sẽ</h4>
                <p>Nước trong hồ bơi thường được xử lý và duy trì sạch sẽ bằng các hệ thống lọc nước và hóa chất. </p>
            </div>
        </div>
    </div>
</template>
<script>
import axios from 'axios';

export default {
    data() {
        return {
            list_ve_thang: [],
            list_ve_ngay: []
        }
    },
    mounted() {
        this.getdata();
    },
    methods: {
        getdata() {
            axios
                .get("http://127.0.0.1:8000/api/ve/get-data")
                .then((res) => {
                    var list;
                    list = res.data.data;
                    console.log(list);
                    list.forEach(($value, index) => {
                        if ($value.loai_ve == 0) {
                            this.list_ve_ngay.push($value);
                        } else {
                            this.list_ve_thang.push($value);
                        }
                    });
                    console.log(res.data.data);
                });
        },
    },
}

</script>
<style>
@import url("https://fonts.googleapis.com");
@import url("https://fonts.gstatic.com");
@import url("https://fonts.googleapis.com/css2?family=Fascinate+Inline&display=swap");
@import url("https://fonts.googleapis.com");
@import url("https://fonts.gstatic.com");
@import url("https://fonts.googleapis.com/css2?family=Fascinate+Inline&family=Playwrite+DE+Grund:wght@100..400&display=swap");

h1 {
    font-family: "Ma Shan Zheng", cursive;
  font-weight: 400;
  font-style: normal;
  color: rgb(10, 144, 233);
}

.h3 {
    font-family: "Playwrite DE Grund", cursive;
    font-optical-sizing: auto;
    font-weight: 200;
    font-style: normal;
}

.backgroundaa {
    min-height: 100vh;
    background-image: url("https://dayboi.vn/wp-content/uploads/2018/11/banner-3.jpg");
    background-size: cover;
    background-position: center;
    display: flex;
    justify-content: center;
    align-items: center;
}
</style>
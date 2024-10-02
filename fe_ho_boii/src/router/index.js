import { createRouter, createWebHistory } from "vue-router"; // cài vue-router: npm install vue-router@next --save

const routes = [
    {
        path : '/',
        component: ()=>import('../layout/components/TrangChu.vue'),
    },
    {
        path : '/trang-chu',
        component: ()=>import('../components/TrangChu/index.vue'),
        meta:{layout: "client"}
    },
    {
        path : '/trang-chu/gioi-thieu',
        component: ()=>import('../components/TrangChu/GioiThieu/index.vue'),
        meta:{layout: "client"}
    },
    {
        path : '/khach-hang/dang-ky',
        component: ()=>import('../components/KhachHang/DangKy/index.vue'),
        meta: {layout: 'blank'}
    },
    {
        path : '/khach-hang/dang-nhap',
        component: ()=>import('../components/KhachHang/DangNhap/index.vue'),
        meta: {layout: 'blank'}
    },
    {
        path : '/chi-tiet/:id_ve',
        component: ()=>import('../components/TrangChu/ChiTiet.vue'),
        meta:{layout: "client"},
        props: true
    },
    {
        path : '/admin/quan-ly-ve',
        component: ()=>import('../components/Admin/QuanLyVe/index.vue'),
        meta:{layout:"admin"}
    },
    {
        path : '/khach-hang/thanh-toan/:id',
        component: ()=>import('../components/KhachHang/HoaDon/index.vue'),
        meta:{layout:"blank"},
        props:true
    },
]

const router = createRouter({
    history: createWebHistory(),
    routes: routes
})
export default router
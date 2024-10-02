import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import Default from './Layout/Wrapper/index.vue'
import Client from './Layout/Wrapper/index.vue'
import Admin from './Layout/Wrapper/TrangChu.vue'
import Blank from './Layout/Wrapper/index_blank.vue'
import Toaster, { Positions } from "@meforma/vue-toaster";

const app = createApp(App)

app.use(Toaster, {
    duration : 3000,
    position: 'top-right'
})
app.use(router)
app.component("default-layout", Default);
app.component("client-layout", Client);
app.component("blank-layout", Blank);
app.component("admin-layout", Admin);
app.mount("#app")
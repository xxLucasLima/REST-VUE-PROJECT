import Vue from 'vue'
import App from './App.vue'
<<<<<<< HEAD
import VueResource from 'vue-resource';

Vue.config.productionTip = false
Vue.use(VueResource);

new Vue({
  render: h => h(App),
=======
import router from './router'
import VueResource from 'vue-resource';

Vue.config.productionTip = false
Vue.use(VueResource); 

new Vue({
  router,
  render: h => h(App)
>>>>>>> Alterações em aluno e professor
}).$mount('#app')

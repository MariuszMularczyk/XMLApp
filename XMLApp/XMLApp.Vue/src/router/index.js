import Vue from 'vue';
import Router from 'vue-router';

Vue.use(Router);

export default new Router({
    routes: [
/*    {
        path: '',
        name: 'menu',
        component: () => import('@/views/Menu')
    },*/

    {
        path: '',
        name: 'productList',
        component: () => import('@/views/product/views/Index')
    },    
    {
        path: '/product/edit/:id',
        name: 'product.edit',
        component: () => import('@/views/product/views/Edit')
    },

  ]
});

import Vue from 'vue';
import Vuex from 'vuex';
import productStore from '../views/product/internalStore';


Vue.use(Vuex);

export default new Vuex.Store({
    namespaced: true,
    modules: {
        productStore
  }
});

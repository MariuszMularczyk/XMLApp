import axios from 'axios';
import router from '@/router/index';
import { getField, updateField } from 'vuex-map-fields';
const namespaced = true;
const state = {
    Product: {
        Id: null,
        Name: '',
        Description: '',
        Price: '',
        Calories: 0,
    }
};

const getters = {
    getField,
    getProduct(state) {
        return state.Product;
    },
};

const mutations = {
    updateField,
    updateUserField(state, product) {
        state.Product.Name = product.Name;
        state.Product.Description = product.Description;
        state.Product.Price = product.Price;
        state.Product.Calories = product.Calories;
    },
    setForm(state, payload) {
        state.Product.Id = payload.id;
        state.Product.Name = payload.name;
        state.Product.Description = payload.description;
        state.Product.Price = payload.price;
        state.Product.Calories = payload.calories;
    },

};

const actions = {
    editProduct({ state }, ) {
        axios.post('/product/edit', state.Product).then(() => router.push({ name: 'productList' }));
    },
    setProductForm({ commit }) {
        axios.get('/product/getProduct/' + router.currentRoute.params.id).then(({ data }) => commit('setForm', data));
    },

};

export default { namespaced , state, getters, mutations, actions };





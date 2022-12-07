import axios from 'axios';
const namespaced = true;

const state = {
    productsList: null
};

const getters = {
  getProductsList(state) {
        return state.productsList;
  },
};

const mutations = {
  setProductsList(state, payload) {
        state.productsList = payload;
  },

};

const actions = {
    setProductsList({commit}) {
        axios.get('/product/getProducts')
            .then(({ data }) => commit('setProductsList', data));
    },
    deleteProduct({ dispatch }, id) {
        axios.delete('/product/deleteProduct/' + id)
            .then(() => dispatch('setProductsList'));
    },
    addProducts({ dispatch }, data) {
        axios.post('/product/add',
            data,
            {
                headers: {
                    'Content-Type': 'multipart/form-data'
                }
            }
        ).then(() => dispatch('setProductsList'));
    },
};

export default {namespaced, state, getters, mutations, actions };





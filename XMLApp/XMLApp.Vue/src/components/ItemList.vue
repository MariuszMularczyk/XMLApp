<template>
    <article class="card">
        <div class="article-details">
            <h3 class="post-title">{{ item.name }}</h3>
            <p class="post-description">{{ item.description }}</p>
            <p class="post-bottom">
                Cena: {{ item.price }}zł, Kalorie: {{ item.calories }}kcal
                <span @click="deleteItem(item.id)" class="btn-span">
                    <img class="buttons" src="../assets/images/delete.png">
                </span>
                <span @click="editItem(item.id)" class="btn-span">
                    <img class="buttons" src="../assets/images/pencil.png">
                </span>
            </p>
        </div>
    </article>
</template>

<script>

    export default {
        name: "ItemList",
        props: ['item'],
        data() {
            return {
            }
        },
        computed: {
        },
        methods: {
            editItem(item) {
                this.$emit('editItem', item)
            },
            deleteItem(item) {
                this.$emit('deleteItem', item)
            }
        },
        mounted() {

        },
    }
</script>

<style scoped lang="scss">
    @import url('https://fonts.googleapis.com/css?family=Roboto:400,700');

    $bg: #eedfcc;
    $text: #777;
    $black: #121212;
    $white: #fff;
    $red: #e04f62;
    $border: #ebebeb;
    $shadow: rgba(0, 0, 0, 0.2);

    @mixin transition($args...) {
        transition: $args;
    }

    * {
        box-sizing: border-box;
        &::before, &::after

    {
        box-sizing: border-box;
    }

    }

    .buttons {
        width: 25px;
        height: 25px;
    }
    .btn-span {
        float: right;
        margin-left: 8px;
    }
    .buttons:hover {
        cursor: pointer;
    }
    .card {

        background: $white;
        box-shadow: 0 0.1875rem 1.5rem $shadow;
        border-radius: 0.375rem;
        overflow: hidden;
    }

    .card-link {
        position: relative;
        display: block;
        color: inherit;
        text-decoration: none;
        &:hover .post-title

    {
        @include transition(color 0.3s ease);
        color: $red;
    }



    }



    .article-details {
        padding: 1.5rem;

    }

    .post-category {
        display: inline-block;
        text-transform: uppercase;
        font-size: 0.75rem;
        font-weight: 700;
        line-height: 1;
        letter-spacing: 0.0625rem;
        margin: 0 0 0.75rem 0;
        padding: 0 0 0.25rem 0;
        border-bottom: 0.125rem solid $border;
    }

    .post-title {
        @include transition(color 0.3s ease);
        font-size: 1.125rem;
        line-height: 1.4;
        color: $black;
        font-weight: 700;
        margin: 0 0 0.5rem 0;
    }

    .post-bottom {
        font-size: 0.875rem;
        line-height: 1;
        margin: 1.125rem 0 0 0;
        padding: 1.125rem 0 0 0;
        border-top: 0.0625rem solid $border;
    }

    @media (max-width: 40rem) {
        #container {
            width: 18rem;
            height: 27.25rem;
        }


    }

    @supports (display: grid) {
        body {
            display: grid;
            grid-template-columns: repeat(4, 1fr);
            grid-gap: 0.625rem;
            grid-template-areas: ". main main ." ". main main .";
        }

        #container {
            grid-area: main;
            align-self: center;
            justify-self: center;
        }

    }
</style>

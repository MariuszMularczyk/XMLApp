<template>
    <div class="container app ">
        <router-view />
    </div>
</template>

<script>

  export default {
        name: 'App',
        data() {
            return {
            }
        }, 
        computed: {
            
        }
  }
</script>

<style >
    .app {
        background-color: white;
        margin-top: 5%;
        margin-bottom: 5%;
    }
    
</style>

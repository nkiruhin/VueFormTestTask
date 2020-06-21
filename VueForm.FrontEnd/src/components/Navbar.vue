<template>
  <div>
    <CNavbar expandable="md" type="dark" color="info">
      <CToggler in-navbar @click="collapsed = !collapsed" />
      <CNavbarBrand>VueForm</CNavbarBrand>
      <CCollapse :show="collapsed" navbar>
        <CNavbarNav>
          <li class="nav-item">
            <router-link class="nav-link" to="/">Home</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" to="/about">About</router-link>
          </li>

        </CNavbarNav>
        <!-- Right aligned nav items -->
        <CNavbarNav class="ml-auto">
          <CDropdown togglerText="Lang"
                     nav
                     placement="bottom-end">
            <CDropdownItem>EN</CDropdownItem>
            <CDropdownItem>RU</CDropdownItem>
          </CDropdown>
          <CDropdown nav
                     togglerText="User"
                     placement="bottom-end">
            <CDropdownItem>Profile</CDropdownItem>
            <CDropdownItem>Signout</CDropdownItem>
          </CDropdown>
        </CNavbarNav>
      </CCollapse>
    </CNavbar>
    <router-view></router-view>
  </div>
</template>

<script lang='ts'>
export default {
  data () {
    return {
      collapsed: false
    }
  }
}
</script>

<!-- Add 'scoped' attribute to limit CSS to this component only -->
<style></style>

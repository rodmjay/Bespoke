import{a as F}from"./chunk-UKFDZ5NH.js";import{a as L}from"./chunk-BQWXN4DA.js";import"./chunk-LAKTUHSI.js";import"./chunk-PAEO5PSF.js";import{a as T}from"./chunk-MEZEMTYB.js";import{d as B,g as V,k as A}from"./chunk-SMJIQ4E4.js";import{a as N,b as R}from"./chunk-3BQEJCHT.js";import"./chunk-BDXJXXVS.js";import"./chunk-BODZH67C.js";import{e as q}from"./chunk-QXZQXA5D.js";import"./chunk-TI2YGS5M.js";import"./chunk-ZHGKNXMS.js";import{Fb as u,Gb as g,Hb as C,Ib as M,Jc as D,Lc as I,Oc as j,Pa as s,Rb as i,Sb as k,Uc as p,Vb as P,Wb as _,Xb as O,_b as h,ab as m,gb as b,nb as v,ob as l,sb as S,sc as y,xb as e,yb as t,zb as r}from"./chunk-DKCBYRU7.js";import{g as E}from"./chunk-GAL4ENT6.js";var G=["*"],W=n=>({"block-action-active":n});function J(n,x){n&1&&(e(0,"span",13),i(1,"Free"),t())}function z(n,x){n&1&&(e(0,"span",14),i(1,"New"),t())}function Y(n,x){if(n&1&&(e(0,"div",15),M(1),t()),n&2){let d=g();S(d.containerClass),l("ngStyle",d.previewStyle)}}function K(n,x){if(n&1&&(e(0,"div")(1,"pre",16)(2,"code"),i(3),t()()()),n&2){let d=g();s(3),k(d.code)}}var w=function(n){return n[n.PREVIEW=0]="PREVIEW",n[n.CODE=1]="CODE",n}(w||{}),U=(()=>{class n{header;code;containerClass;previewStyle;free=!0;new=!1;BlockView=w;blockView=w.PREVIEW;activateView(d,c){this.blockView=c,d.preventDefault()}copyCode(d){return E(this,null,function*(){yield navigator.clipboard.writeText(this.code),d.preventDefault()})}static \u0275fac=function(c){return new(c||n)};static \u0275cmp=m({type:n,selectors:[["block-viewer"]],inputs:{header:"header",code:"code",containerClass:"containerClass",previewStyle:"previewStyle",free:[2,"free","free",y],new:[2,"new","new",y]},ngContentSelectors:G,decls:19,vars:13,consts:[[1,"block-section"],[1,"block-header"],[1,"block-title"],["class","badge-free",4,"ngIf"],["class","badge-new",4,"ngIf"],[1,"block-actions"],["tabindex","0",3,"click","ngClass"],[3,"click","ngClass"],["pTooltip","Copied to clipboard","tooltipEvent","focus","tooltipPosition","bottom",1,"block-action-copy",3,"click"],[1,"pi","pi-copy","m-0"],[1,"block-content"],[3,"class","ngStyle",4,"ngIf"],[4,"ngIf"],[1,"badge-free"],[1,"badge-new"],[3,"ngStyle"],[1,"app-code"]],template:function(c,a){c&1&&(C(),e(0,"div",0)(1,"div",1)(2,"span",2)(3,"span"),i(4),t(),b(5,J,2,0,"span",3)(6,z,2,0,"span",4),t(),e(7,"div",5)(8,"a",6),u("click",function(o){return a.activateView(o,a.BlockView.PREVIEW)}),e(9,"span"),i(10,"Preview"),t()(),e(11,"a",7),u("click",function(o){return a.activateView(o,a.BlockView.CODE)}),e(12,"span"),i(13,"Code"),t()(),e(14,"a",8),u("click",function(o){return a.copyCode(o)}),r(15,"i",9),t()()(),e(16,"div",10),b(17,Y,2,3,"div",11)(18,K,4,1,"div",12),t()()),c&2&&(s(4),k(a.header),s(),l("ngIf",a.free),s(),l("ngIf",a.new),s(2),l("ngClass",h(9,W,a.blockView===a.BlockView.PREVIEW)),s(3),l("ngClass",h(11,W,a.blockView===a.BlockView.CODE)),v("tabindex","0"),s(3),v("tabindex","0"),s(3),l("ngIf",a.blockView===a.BlockView.PREVIEW),s(),l("ngIf",a.blockView===a.BlockView.CODE))},dependencies:[p,D,I,j,R,N],styles:[".block-section[_ngcontent-%COMP%]{margin-bottom:4rem}.block-header[_ngcontent-%COMP%]{padding:1rem 2rem;background-color:var(--surface-card);border-top-left-radius:4px;border-top-right-radius:4px;border:1px solid var(--surface-border);display:flex;align-items:center;justify-content:space-between}.block-header[_ngcontent-%COMP%]   .block-title[_ngcontent-%COMP%]{font-weight:700;display:inline-flex;align-items:center}.block-header[_ngcontent-%COMP%]   .block-title[_ngcontent-%COMP%]   .badge-free[_ngcontent-%COMP%]{border-radius:4px;padding:.25rem .5rem;background-color:var(--p-orange-500);color:#fff;margin-left:1rem;font-weight:700;font-size:.875rem}.block-header[_ngcontent-%COMP%]   .block-actions[_ngcontent-%COMP%]{display:flex;align-items:center;justify-content:space-between;-webkit-user-select:none;user-select:none;margin-left:1rem}.block-header[_ngcontent-%COMP%]   .block-actions[_ngcontent-%COMP%]   a[_ngcontent-%COMP%]{display:flex;align-items:center;margin-right:.75rem;padding:.5rem 1rem;border-radius:4px;border:1px solid transparent;transition:background-color .2s;cursor:pointer}.block-header[_ngcontent-%COMP%]   .block-actions[_ngcontent-%COMP%]   a[_ngcontent-%COMP%]:last-child{margin-right:0}.block-header[_ngcontent-%COMP%]   .block-actions[_ngcontent-%COMP%]   a[_ngcontent-%COMP%]:not(.block-action-disabled):hover{background-color:var(--surface-hover)}.block-header[_ngcontent-%COMP%]   .block-actions[_ngcontent-%COMP%]   a.block-action-active[_ngcontent-%COMP%]{border-color:var(--primary-color);color:var(--primary-color)}.block-header[_ngcontent-%COMP%]   .block-actions[_ngcontent-%COMP%]   a.block-action-copy[_ngcontent-%COMP%]   i[_ngcontent-%COMP%]{color:var(--primary-color);font-size:1.25rem}.block-header[_ngcontent-%COMP%]   .block-actions[_ngcontent-%COMP%]   a.block-action-disabled[_ngcontent-%COMP%]{opacity:.6;cursor:auto!important}.block-header[_ngcontent-%COMP%]   .block-actions[_ngcontent-%COMP%]   a[_ngcontent-%COMP%]   i[_ngcontent-%COMP%]{margin-right:.5rem}.block-content[_ngcontent-%COMP%]{padding:0;border:1px solid var(--surface-border);border-top:0 none}pre[class*=language-][_ngcontent-%COMP%]{margin:0!important}pre[class*=language-][_ngcontent-%COMP%]:before, pre[class*=language-][_ngcontent-%COMP%]:after{display:none!important}pre[class*=language-][_ngcontent-%COMP%]   code[_ngcontent-%COMP%]{border-left:0 none!important;box-shadow:none!important;background:var(--surface-card)!important;margin:0;color:var(--text-color);font-size:14px;padding:0 2rem!important}pre[class*=language-][_ngcontent-%COMP%]   code[_ngcontent-%COMP%]   .token.tag[_ngcontent-%COMP%], pre[class*=language-][_ngcontent-%COMP%]   code[_ngcontent-%COMP%]   .token.keyword[_ngcontent-%COMP%], pre[class*=language-][_ngcontent-%COMP%]   code[_ngcontent-%COMP%]   .token.attr-name[_ngcontent-%COMP%], pre[class*=language-][_ngcontent-%COMP%]   code[_ngcontent-%COMP%]   .token.attr-string[_ngcontent-%COMP%]{color:#2196f3!important}pre[class*=language-][_ngcontent-%COMP%]   code[_ngcontent-%COMP%]   .token.attr-value[_ngcontent-%COMP%]{color:#4caf50!important}pre[class*=language-][_ngcontent-%COMP%]   code[_ngcontent-%COMP%]   .token.punctuation[_ngcontent-%COMP%]{color:var(--text-color)}pre[class*=language-][_ngcontent-%COMP%]   code[_ngcontent-%COMP%]   .token.operator[_ngcontent-%COMP%], pre[class*=language-][_ngcontent-%COMP%]   code[_ngcontent-%COMP%]   .token.string[_ngcontent-%COMP%]{background:transparent}@media screen and (max-width: 575px){.block-header[_ngcontent-%COMP%]{flex-direction:column;align-items:start}.block-header[_ngcontent-%COMP%]   .block-actions[_ngcontent-%COMP%]{margin-top:1rem;margin-left:0}}"]})}return n})();var H=(()=>{class n{block1=`
  <div class="grid grid-cols-12 gap-4 grid-nogutter bg-surface-0 dark:bg-surface-950 text-surface-800 dark:text-surface-50">
    <div class="col-span-12 md:col-span-6 p-12 text-center md:text-left flex items-center ">
        <section>
            <span class="block text-6xl font-bold mb-1">Create the screens </span>
            <div class="text-6xl text-primary font-bold mb-4">your visitors deserve to see</div>
            <p class="mt-0 mb-6 text-surface-700 dark:text-surface-100 leading-normal">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.</p>

            <p-button label="Learn More" type="button" class="mr-4" raised></p-button>
            <p-button label="Live Demo" type="button" outlined></p-button>
        </section>
    </div>
    <div class="col-span-12 md:col-span-6 overflow-hidden">
        <img src="/demo/images/blocks/hero/hero-1.png" alt="Image" class="md:ml-auto block md:h-full" style="clip-path: polygon(8% 0, 100% 0%, 100% 100%, 0 100%)">
    </div>
 </div>`;block2=`
  <div class="bg-surface-0 dark:bg-surface-950 px-6 py-20 md:px-12 lg:px-20 text-center">
    <div class="mb-4 font-bold text-3xl">
        <span class="text-surface-900 dark:text-surface-0">One Product, </span>
        <span class="text-primary">Many Solutions</span>
    </div>
    <div class="text-surface-700 dark:text-surface-100 mb-12">Ac turpis egestas maecenas pharetra convallis posuere morbi leo urna.</div>
    <div class="grid grid-cols-12 gap-4">
        <div class="col-span-12 md:col-span-4 mb-6 px-8">
            <span class="p-4 shadow mb-4 inline-block bg-surface-0 dark:bg-surface-900" style="border-radius: 10px">
                <i class="pi pi-desktop text-4xl text-primary"></i>
            </span>
            <div class="text-surface-900 dark:text-surface-0 text-xl mb-4 font-medium">Built for Developers</div>
            <span class="text-surface-700 dark:text-surface-100 leading-normal">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</span>
        </div>
        <div class="col-span-12 md:col-span-4 mb-6 px-8">
            <span class="p-4 shadow mb-4 inline-block bg-surface-0 dark:bg-surface-900" style="border-radius: 10px">
                <i class="pi pi-lock text-4xl text-primary"></i>
            </span>
            <div class="text-surface-900 dark:text-surface-0 text-xl mb-4 font-medium">End-to-End Encryption</div>
            <span class="text-surface-700 dark:text-surface-100 leading-normal">Risus nec feugiat in fermentum posuere urna nec. Posuere sollicitudin aliquam ultrices sagittis.</span>
        </div>
        <div class="col-span-12 md:col-span-4 mb-6 px-8">
            <span class="p-4 shadow mb-4 inline-block bg-surface-0 dark:bg-surface-900" style="border-radius: 10px">
                <i class="pi pi-check-circle text-4xl text-primary"></i>
            </span>
            <div class="text-surface-900 dark:text-surface-0 text-xl mb-4 font-medium">Easy to Use</div>
            <span class="text-surface-700 dark:text-surface-100 leading-normal">Ornare suspendisse sed nisi lacus sed viverra tellus. Neque volutpat ac tincidunt vitae semper.</span>
        </div>
        <div class="col-span-12 md:col-span-4 mb-6 px-8">
            <span class="p-4 shadow mb-4 inline-block bg-surface-0 dark:bg-surface-900" style="border-radius: 10px">
                <i class="pi pi-globe text-4xl text-primary"></i>
            </span>
            <div class="text-surface-900 dark:text-surface-0 text-xl mb-4 font-medium">Fast & Global Support</div>
            <span class="text-surface-700 dark:text-surface-100 leading-normal">Fermentum et sollicitudin ac orci phasellus egestas tellus rutrum tellus.</span>
        </div>
        <div class="col-span-12 md:col-span-4 mb-6 px-8">
            <span class="p-4 shadow mb-4 inline-block bg-surface-0 dark:bg-surface-900" style="border-radius: 10px">
                <i class="pi pi-github text-4xl text-primary"></i>
            </span>
            <div class="text-surface-900 dark:text-surface-0 text-xl mb-4 font-medium">Open Source</div>
            <span class="text-surface-700 dark:text-surface-100 leading-normal">Nec tincidunt praesent semper feugiat. Sed adipiscing diam donec adipiscing tristique risus nec feugiat. </span>
        </div>
        <div class="col-span-12 md:col-span-4 md:mb-6 mb-0 px-4">
            <span class="p-4 shadow mb-4 inline-block bg-surface-0 dark:bg-surface-900" style="border-radius: 10px">
                <i class="pi pi-shield text-4xl text-primary"></i>
            </span>
            <div class="text-surface-900 dark:text-surface-0 text-xl mb-4 font-medium">Trusted Securitty</div>
            <span class="text-surface-700 dark:text-surface-100 leading-normal">Mattis rhoncus urna neque viverra justo nec ultrices. Id cursus metus aliquam eleifend.</span>
        </div>
    </div>
  </div>`;block3=`
  <div class="bg-surface-50 dark:bg-surface-950 px-6 py-20 md:px-12 lg:px-20">
    <div class="text-surface-900 dark:text-surface-0 font-bold text-6xl mb-6 text-center">Pricing Plans</div>
    <div class="text-surface-700 dark:text-surface-100 text-xl mb-12 text-center leading-normal">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit numquam eligendi quos.</div>

    <div class="grid grid-cols-12 gap-4">
        <div class="col-span-12 lg:col-span-4">
            <div class="p-4 h-full">
                <div class="shadow p-4 h-full flex flex-col bg-surface-0 dark:bg-surface-900" style="border-radius: 6px">
                    <div class="text-surface-900 dark:text-surface-0 font-medium text-xl mb-2">Basic</div>
                    <div class="text-surface-600 dark:text-surface-200">Plan description</div>
                    <hr class="my-4 mx-0 border-t border-0 border-surface-200 dark:border-surface-700" />
                    <div class="flex items-center">
                        <span class="font-bold text-2xl text-surface-900 dark:text-surface-0">$9</span>
                        <span class="ml-2 font-medium text-surface-600 dark:text-surface-200">per month</span>
                    </div>
                    <hr class="my-4 mx-0 border-t border-0 border-surface-200 dark:border-surface-700" />
                    <ul class="list-none p-0 m-0 flex-grow-1">
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Arcu vitae elementum</span>
                        </li>
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Dui faucibus in ornare</span>
                        </li>
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Morbi tincidunt augue</span>
                        </li>
                    </ul>
                    <hr class="mt-auto mb-4 mx-0 border-t border-0 border-surface-200 dark:border-surface-700" />
                    <p-button label="Buy Now" styleClass="p-4 w-full"></p-button>
                </div>
            </div>
        </div>

        <div class="col-span-12 lg:col-span-4">
            <div class="p-4 h-full">
                <div class="shadow p-4 h-full flex flex-col bg-surface-0 dark:bg-surface-900" style="border-radius: 6px">
                    <div class="text-surface-900 dark:text-surface-0 font-medium text-xl mb-2">Premium</div>
                    <div class="text-surface-600 dark:text-surface-200">Plan description</div>
                    <hr class="my-4 mx-0 border-t border-0 border-surface-200 dark:border-surface-700" />
                    <div class="flex items-center">
                        <span class="font-bold text-2xl text-surface-900 dark:text-surface-0">$29</span>
                        <span class="ml-2 font-medium text-surface-600 dark:text-surface-200">per month</span>
                    </div>
                    <hr class="my-4 mx-0 border-t border-0 border-surface-200 dark:border-surface-700" />
                    <ul class="list-none p-0 m-0 flex-grow-1">
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Arcu vitae elementum</span>
                        </li>
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Dui faucibus in ornare</span>
                        </li>
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Morbi tincidunt augue</span>
                        </li>
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Duis ultricies lacus sed</span>
                        </li>
                    </ul>
                    <hr class="mt-auto mb-4 mx-0 border-t border-0 border-surface-200 dark:border-surface-700" />
                    <p-button label="Buy Now" styleClass="p-4 w-full"></p-button>
                </div>
            </div>
        </div>

        <div class="col-span-12 lg:col-span-4">
            <div class="p-4 h-full">
                <div class="shadow p-4 flex flex-col bg-surface-0 dark:bg-surface-900" style="border-radius: 6px">
                    <div class="text-surface-900 dark:text-surface-0 font-medium text-xl mb-2">Enterprise</div>
                    <div class="text-surface-600 dark:text-surface-200">Plan description</div>
                    <hr class="my-4 mx-0 border-t border-0 border-surface-200 dark:border-surface-700" />
                    <div class="flex items-center">
                        <span class="font-bold text-2xl text-surface-900 dark:text-surface-0">$49</span>
                        <span class="ml-2 font-medium text-surface-600 dark:text-surface-200">per month</span>
                    </div>
                    <hr class="my-4 mx-0 border-t border-0 border-surface-200 dark:border-surface-700" />
                    <ul class="list-none p-0 m-0 flex-grow-1">
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Arcu vitae elementum</span>
                        </li>
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Dui faucibus in ornare</span>
                        </li>
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Morbi tincidunt augue</span>
                        </li>
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Duis ultricies lacus sed</span>
                        </li>
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Imperdiet proin</span>
                        </li>
                        <li class="flex items-center mb-4">
                            <i class="pi pi-check-circle text-green-500 mr-2"></i>
                            <span class="text-surface-900 dark:text-surface-0">Nisi scelerisque</span>
                        </li>
                    </ul>
                    <hr class="mb-4 mx-0 border-t border-0 border-surface-200 dark:border-surface-700" />
                    <p-button label="Buy Now" styleClass="p-4 w-full" outlined></p-button>
                </div>
            </div>
        </div>
    </div>
  </div>`;block4=`
  <div class="bg-surface-0 dark:bg-surface-950 px-6 py-20 md:px-12 lg:px-20">
    <div class="text-surface-700 dark:text-surface-100 text-center">
        <div class="text-primary font-bold mb-4"><i class="pi pi-discord"></i>&nbsp;POWERED BY DISCORD</div>
        <div class="text-surface-900 dark:text-surface-0 font-bold text-5xl mb-4">Join Our Design Community</div>
        <div class="text-surface-700 dark:text-surface-100 text-2xl mb-8">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit numquam eligendi quos.</div>
        <p-button label="Join Now" icon="pi pi-discord" class="font-bold px-8 py-4 whitespace-nowrap" raised rounded></p-button>
    </div>
  </div>`;block5=`
  <div class="bg-slate-900 text-gray-100 p-4 flex justify-between lg:justify-center items-center flex-wrap">
    <div class="font-bold mr-20">\u{1F525} Hot Deals!</div>
    <div class="items-center hidden lg:flex">
        <span class="leading-normal">Libero voluptatum atque exercitationem praesentium provident odit.</span>
    </div>
    <a class="flex items-center ml-2 mr-20">
        <a class="text-white" href="#"><span class="underline font-bold">Learn More</span></a>
    </a>
    <a  class=" flex items-center no-underline justify-center rounded-full text-gray-50 hover:bg-slate-700 cursor-pointer transition-colors duration-150" style="width:2rem; height: 2rem">
        <i class="pi pi-times"></i>
    </a>
  </div>`;block6=`
  <div class="bg-surface-0 dark:bg-surface-950 px-6 py-8 md:px-12 lg:px-20">
    <ul class="list-none p-0 m-0 flex items-center font-medium mb-4">
        <li>
            <a class="text-surface-500 dark:text-surface-300 no-underline leading-normal cursor-pointer">Application</a>
        </li>
        <li class="px-2">
            <i class="pi pi-angle-right text-surface-500 dark:text-surface-300 leading-normal"></i>
        </li>
        <li>
            <span class="text-surface-900 dark:text-surface-0 leading-normal">Analytics</span>
        </li>
    </ul>
    <div class="flex items-start flex-col lg:justify-between lg:flex-row">
        <div>
            <div class="font-medium text-3xl text-surface-900 dark:text-surface-0">Customers</div>
            <div class="flex items-center text-surface-700 dark:text-surface-100 flex-wrap">
                <div class="mr-8 flex items-center mt-4">
                    <i class="pi pi-users mr-2"></i>
                    <span>332 Active Users</span>
                </div>
                <div class="mr-8 flex items-center mt-4">
                    <i class="pi pi-globe mr-2"></i>
                    <span>9402 Sessions</span>
                </div>
                <div class="flex items-center mt-4">
                    <i class="pi pi-clock mr-2"></i>
                    <span>2.32m Avg. Duration</span>
                </div>
            </div>
        </div>
        <div class="mt-4 lg:mt-0">
            <p-button label="Add" styleClass="mr-2" outlined icon="pi pi-user-plus"></p-button>
            <p-button label="Save" icon="pi pi-check"></p-button>
        </div>
    </div>
  </div>`;block7=`
  <div class="bg-surface-50 dark:bg-surface-950 px-6 py-8 md:px-12 lg:px-20">
    <div class="grid grid-cols-12 gap-4">
        <div class="col-span-12 md:col-span-6 lg:col-span-3">
            <div class="bg-surface-0 dark:bg-surface-900 shadow p-4 rounded">
                <div class="flex justify-between mb-4">
                    <div>
                        <span class="block text-surface-500 dark:text-surface-300 font-medium mb-4">Orders</span>
                        <div class="text-surface-900 dark:text-surface-0 font-medium text-xl">152</div>
                    </div>
                    <div class="flex items-center justify-center bg-blue-100 rounded" style="width:2.5rem;height:2.5rem">
                        <i class="pi pi-shopping-cart text-primary text-xl"></i>
                    </div>
                </div>
                <span class="text-green-500 font-medium">24 new </span>
                <span class="text-surface-500 dark:text-surface-300">since last visit</span>
            </div>
        </div>
        <div class="col-span-12 md:col-span-6 lg:col-span-3">
            <div class="bg-surface-0 dark:bg-surface-900 shadow p-4 rounded">
                <div class="flex justify-between mb-4">
                    <div>
                        <span class="block text-surface-500 dark:text-surface-300 font-medium mb-4">Revenue</span>
                        <div class="text-surface-900 dark:text-surface-0 font-medium text-xl">$2.100</div>
                    </div>
                    <div class="flex items-center justify-center bg-orange-100 rounded" style="width:2.5rem;height:2.5rem">
                        <i class="pi pi-map-marker text-orange-500 text-xl"></i>
                    </div>
                </div>
                <span class="text-green-500 font-medium">%52+ </span>
                <span class="text-surface-500 dark:text-surface-300">since last week</span>
            </div>
        </div>
        <div class="col-span-12 md:col-span-6 lg:col-span-3">
            <div class="bg-surface-0 dark:bg-surface-900 shadow p-4 rounded">
                <div class="flex justify-between mb-4">
                    <div>
                        <span class="block text-surface-500 dark:text-surface-300 font-medium mb-4">Customers</span>
                        <div class="text-surface-900 dark:text-surface-0 font-medium text-xl">28441</div>
                    </div>
                    <div class="flex items-center justify-center bg-cyan-100 rounded" style="width:2.5rem;height:2.5rem">
                        <i class="pi pi-inbox text-cyan-500 text-xl"></i>
                    </div>
                </div>
                <span class="text-green-500 font-medium">520  </span>
                <span class="text-surface-500 dark:text-surface-300">newly registered</span>
            </div>
        </div>
        <div class="col-span-12 md:col-span-6 lg:col-span-3">
            <div class="bg-surface-0 dark:bg-surface-900 shadow p-4 rounded">
                <div class="flex justify-between mb-4">
                    <div>
                        <span class="block text-surface-500 dark:text-surface-300 font-medium mb-4">Comments</span>
                        <div class="text-surface-900 dark:text-surface-0 font-medium text-xl">152 Unread</div>
                    </div>
                    <div class="flex items-center justify-center bg-purple-100 rounded" style="width:2.5rem;height:2.5rem">
                        <i class="pi pi-comment text-purple-500 text-xl"></i>
                    </div>
                </div>
                <span class="text-green-500 font-medium">85 </span>
                <span class="text-surface-500 dark:text-surface-300">responded</span>
            </div>
        </div>
    </div>
  </div>`;block8=`
  <div class="bg-surface-0 dark:bg-surface-900 p-6 shadow rounded w-full lg:w-6/12">
    <div class="text-center mb-8">
        <img src="/demo/images/blocks/logos/hyper.svg" alt="Image" height="50" class="mb-4">
        <div class="text-surface-900 dark:text-surface-0 text-3xl font-medium mb-4">Welcome Back</div>
        <span class="text-surface-600 dark:text-surface-200 font-medium leading-normal">Don't have an account?</span>
        <a class="font-medium no-underline ml-2 text-primary cursor-pointer">Create today!</a>
    </div>

    <div>
        <label for="email1" class="block text-surface-900 dark:text-surface-0 font-medium mb-2">Email</label>
        <input pInputText id="email1" type="text" placeholder="Email address" class="w-full mb-4" />

        <label for="password1" class="block text-surface-900 dark:text-surface-0 font-medium mb-2">Password</label>
        <input pInputText id="password1" type="password" placeholder="Password" class="w-full mb-4" />

        <div class="flex items-center justify-between mb-12">
            <div class="flex items-center">
                <p-checkbox id="rememberme1" [binary]="true" [(ngModel)]="checked" class="mr-2 block"></p-checkbox>
                <label for="rememberme1" class="text-surface-900 dark:text-surface-0">Remember me</label>
            </div>
            <a class="font-medium no-underline ml-2 text-primary text-right cursor-pointer">Forgot password?</a>
        </div>

        <p-button label="Sign In" icon="pi pi-user" class="w-full"></p-button>
    </div>
  </div>`;block9=`
  <div class="bg-surface-0 dark:bg-surface-950">
    <div class="font-medium text-3xl text-surface-900 dark:text-surface-0 mb-4">Movie Information</div>
    <div class="text-surface-500 dark:text-surface-300 mb-8">Morbi tristique blandit turpis. In viverra ligula id nulla hendrerit rutrum.</div>
    <ul class="list-none p-0 m-0">
        <li class="flex items-center py-4 px-2 border-t border-surface-200 dark:border-surface-700 flex-wrap">
            <div class="text-surface-500 dark:text-surface-300 w-6/12 md:w-2/12 font-medium">Title</div>
            <div class="text-surface-900 dark:text-surface-0 w-full md:w-8/12 md:order-none order-1">Heat</div>
            <div class="w-6/12 md:w-2/12 flex justify-end">
                <p-button label="Edit" icon="pi pi-pencil" text></p-button>
            </div>
        </li>
        <li class="flex items-center py-4 px-2 border-t border-surface-200 dark:border-surface-700 flex-wrap">
            <div class="text-surface-500 dark:text-surface-300 w-6/12 md:w-2/12 font-medium">Genre</div>
            <div class="text-surface-900 dark:text-surface-0 w-full md:w-8/12 md:order-none order-1">
                <p-chip label="Crime" styleClass="mr-2"></p-chip>
                <p-chip label="Drama" styleClass="mr-2"></p-chip>
                <p-chip label="Thriller"></p-chip>
            </div>
            <div class="w-6/12 md:w-2/12 flex justify-end">
                <p-button label="Edit" icon="pi pi-pencil" text></p-button>
            </div>
        </li>
        <li class="flex items-center py-4 px-2 border-t border-surface-200 dark:border-surface-700 flex-wrap">
            <div class="text-surface-500 dark:text-surface-300 w-6/12 md:w-2/12 font-medium">Director</div>
            <div class="text-surface-900 dark:text-surface-0 w-full md:w-8/12 md:order-none order-1">Michael Mann</div>
            <div class="w-6/12 md:w-2/12 flex justify-end">
                <p-button label="Edit" icon="pi pi-pencil" text></p-button>
            </div>
        </li>
        <li class="flex items-center py-4 px-2 border-t border-surface-200 dark:border-surface-700 flex-wrap">
            <div class="text-surface-500 dark:text-surface-300 w-6/12 md:w-2/12 font-medium">Actors</div>
            <div class="text-surface-900 dark:text-surface-0 w-full md:w-8/12 md:order-none order-1">Robert De Niro, Al Pacino</div>
            <div class="w-6/12 md:w-2/12 flex justify-end">
                <p-button label="Edit" icon="pi pi-pencil" text></p-button>
            </div>
        </li>
        <li class="flex items-center py-4 px-2 border-t border-b border-surface-200 dark:border-surface-700 flex-wrap">
            <div class="text-surface-500 dark:text-surface-300 w-6/12 md:w-2/12 font-medium">Plot</div>
            <div class="text-surface-900 dark:text-surface-0 w-full md:w-8/12 md:order-none order-1 leading-normal">
                A group of professional bank robbers start to feel the heat from police
                when they unknowingly leave a clue at their latest heist.</div>
            <div class="w-6/12 md:w-2/12 flex justify-end">
                <p-button label="Edit" icon="pi pi-pencil" text></p-button>
            </div>
        </li>
    </ul>
  </div>`;block10=`
  <div class="bg-surface-0 dark:bg-surface-900 p-6 shadow rounded">
    <div class="text-3xl font-medium text-surface-900 dark:text-surface-0 mb-4">Card Title</div>
    <div class="font-medium text-surface-500 dark:text-surface-300 mb-4">Vivamus id nisl interdum, blandit augue sit amet, eleifend mi.</div>
    <div style="height: 150px" class="border-2 border-dashed border-surface-200 dark:border-surface-700"></div>
  </div>`;checked=!1;static \u0275fac=function(c){return new(c||n)};static \u0275cmp=m({type:n,selectors:[["app-blocks"]],decls:369,vars:11,consts:[["header","Hero","free","",3,"code"],[1,"grid","grid-cols-12","gap-4","grid-nogutter","bg-surface-0","dark:bg-surface-950","text-surface-800","dark:text-surface-50"],[1,"col-span-12","md:col-span-6","p-12","text-center","md:text-left","flex","items-center"],[1,"block","text-6xl","font-bold","mb-1"],[1,"text-6xl","text-primary","font-bold","mb-4"],[1,"mt-0","mb-6","text-surface-700","dark:text-surface-100","leading-normal"],["label","Learn More","type","button","raised","",1,"mr-4"],["label","Live Demo","type","button","outlined",""],[1,"col-span-12","md:col-span-6","overflow-hidden"],["src","/demo/images/blocks/hero/hero-1.png","alt","Image",1,"md:ml-auto","block","md:h-full",2,"clip-path","polygon(8% 0, 100% 0%, 100% 100%, 0 100%)"],["header","Feature","free","",3,"code"],[1,"bg-surface-0","dark:bg-surface-950","px-6","py-20","md:px-12","lg:px-20","text-center"],[1,"mb-4","font-bold","text-3xl"],[1,"text-surface-900","dark:text-surface-0"],[1,"text-primary"],[1,"text-surface-700","dark:text-surface-100","mb-12"],[1,"grid","grid-cols-12","gap-4"],[1,"col-span-12","md:col-span-4","mb-6","px-8"],[1,"p-4","shadow","mb-4","inline-block","bg-surface-0","dark:bg-surface-900",2,"border-radius","10px"],[1,"pi","pi-desktop","text-4xl","text-primary"],[1,"text-surface-900","dark:text-surface-0","text-xl","mb-4","font-medium"],[1,"text-surface-700","dark:text-surface-100","leading-normal"],[1,"pi","pi-lock","text-4xl","text-primary"],[1,"pi","pi-check-circle","text-4xl","text-primary"],[1,"pi","pi-globe","text-4xl","text-primary"],[1,"pi","pi-github","text-4xl","text-primary"],[1,"col-span-12","md:col-span-4","md:mb-6","mb-0","px-4"],[1,"pi","pi-shield","text-4xl","text-primary"],["header","Pricing","free","",3,"code"],[1,"bg-surface-50","dark:bg-surface-950","px-6","py-20","md:px-12","lg:px-20"],[1,"text-surface-900","dark:text-surface-0","font-bold","text-6xl","mb-6","text-center"],[1,"text-surface-700","dark:text-surface-100","text-xl","mb-12","text-center","leading-normal"],[1,"col-span-12","lg:col-span-4"],[1,"p-4","h-full"],[1,"shadow","p-4","h-full","flex","flex-col","bg-surface-0","dark:bg-surface-900",2,"border-radius","6px"],[1,"text-surface-900","dark:text-surface-0","font-medium","text-xl","mb-2"],[1,"text-surface-600","dark:text-surface-200"],[1,"my-4","mx-0","border-t","border-0","border-surface-200","dark:border-surface-700"],[1,"flex","items-center"],[1,"font-bold","text-2xl","text-surface-900","dark:text-surface-0"],[1,"ml-2","font-medium","text-surface-600","dark:text-surface-200"],[1,"list-none","p-0","m-0","flex-grow-1"],[1,"flex","items-center","mb-4"],[1,"pi","pi-check-circle","text-green-500","mr-2"],[1,"mt-auto","mb-4","mx-0","border-t","border-0","border-surface-200","dark:border-surface-700"],["label","Buy Now","styleClass","p-4 w-full"],[1,"shadow","p-4","flex","flex-col","bg-surface-0","dark:bg-surface-900",2,"border-radius","6px"],[1,"mb-4","mx-0","border-t","border-0","border-surface-200","dark:border-surface-700"],["label","Buy Now","styleClass","p-4 w-full","outlined",""],["header","Call to Action","free","",3,"code"],[1,"bg-surface-0","dark:bg-surface-950","px-6","py-20","md:px-12","lg:px-20"],[1,"text-surface-700","dark:text-surface-100","text-center"],[1,"text-primary","font-bold","mb-4"],[1,"pi","pi-discord"],[1,"text-surface-900","dark:text-surface-0","font-bold","text-5xl","mb-4"],[1,"text-surface-700","dark:text-surface-100","text-2xl","mb-8"],["label","Join Now","icon","pi pi-discord","raised","","rounded","",1,"font-bold","px-8","py-4","whitespace-nowrap"],["header","Banner","containerClass","bg-surface-0 dark:bg-surface-950 py-20","free","",3,"code"],[1,"bg-slate-900","text-gray-100","p-4","flex","justify-between","lg:justify-center","items-center","flex-wrap"],[1,"font-bold","mr-20"],[1,"items-center","hidden","lg:flex"],[1,"leading-normal"],[1,"flex","items-center","ml-2","mr-20"],["href","#",1,"text-white"],[1,"underline","font-bold"],[1,"flex","items-center","no-underline","justify-center","rounded-full","text-gray-50","hover:bg-slate-700","cursor-pointer","transition-colors","duration-150",2,"width","2rem","height","2rem"],[1,"pi","pi-times"],[1,"block-category-title"],["header","Page Heading","free","",3,"code"],[1,"bg-surface-0","dark:bg-surface-950","px-6","py-8","md:px-12","lg:px-20"],[1,"list-none","p-0","m-0","flex","items-center","font-medium","mb-4"],[1,"text-surface-500","dark:text-surface-300","no-underline","leading-normal","cursor-pointer"],[1,"px-2"],[1,"pi","pi-angle-right","text-surface-500","dark:text-surface-300","leading-normal"],[1,"text-surface-900","dark:text-surface-0","leading-normal"],[1,"flex","items-start","flex-col","lg:justify-between","lg:flex-row"],[1,"font-medium","text-3xl","text-surface-900","dark:text-surface-0"],[1,"flex","items-center","text-surface-700","dark:text-surface-100","flex-wrap"],[1,"mr-8","flex","items-center","mt-4"],[1,"pi","pi-users","mr-2"],[1,"pi","pi-globe","mr-2"],[1,"flex","items-center","mt-4"],[1,"pi","pi-clock","mr-2"],[1,"mt-4","lg:mt-0"],["label","Add","styleClass","mr-2","outlined","","icon","pi pi-user-plus"],["label","Save","icon","pi pi-check"],["header","Stats","free","",3,"code"],[1,"bg-surface-50","dark:bg-surface-950","px-6","py-8","md:px-12","lg:px-20"],[1,"col-span-12","md:col-span-6","lg:col-span-3"],[1,"bg-surface-0","dark:bg-surface-900","shadow","p-4","rounded"],[1,"flex","justify-between","mb-4"],[1,"block","text-surface-500","dark:text-surface-300","font-medium","mb-4"],[1,"text-surface-900","dark:text-surface-0","font-medium","text-xl"],[1,"flex","items-center","justify-center","bg-blue-100","rounded",2,"width","2.5rem","height","2.5rem"],[1,"pi","pi-shopping-cart","text-primary","text-xl"],[1,"text-green-500","font-medium"],[1,"text-surface-500","dark:text-surface-300"],[1,"flex","items-center","justify-center","bg-orange-100","rounded",2,"width","2.5rem","height","2.5rem"],[1,"pi","pi-map-marker","text-orange-500","text-xl"],[1,"flex","items-center","justify-center","bg-cyan-100","rounded",2,"width","2.5rem","height","2.5rem"],[1,"pi","pi-inbox","text-cyan-500","text-xl"],[1,"flex","items-center","justify-center","bg-purple-100","rounded",2,"width","2.5rem","height","2.5rem"],[1,"pi","pi-comment","text-purple-500","text-xl"],["header","Sign-In","containerClass","bg-surface-50 dark:bg-surface-950 px-6 py-20 md:px-12 lg:px-20 flex items-center justify-center","free","",3,"code"],[1,"bg-surface-0","dark:bg-surface-900","p-6","shadow","rounded","w-full","lg:w-6/12"],[1,"text-center","mb-8"],["src","/demo/images/blocks/logos/hyper.svg","alt","Image","height","50",1,"mb-4","mx-auto"],[1,"text-surface-900","dark:text-surface-0","text-3xl","font-medium","mb-4"],[1,"text-surface-600","dark:text-surface-200","font-medium","leading-normal"],[1,"font-medium","no-underline","ml-2","text-primary","cursor-pointer"],["for","email1",1,"block","text-surface-900","dark:text-surface-0","font-medium","mb-2"],["pInputText","","id","email1","type","text","placeholder","Email address",1,"w-full","mb-4"],["for","password1",1,"block","text-surface-900","dark:text-surface-0","font-medium","mb-2"],["pInputText","","id","password1","type","password","placeholder","Password",1,"w-full","mb-4"],[1,"flex","items-center","justify-between","mb-12"],["id","rememberme1","binary","",1,"mr-2",3,"ngModelChange","ngModel"],["for","rememberme1",1,"text-surface-900","dark:text-surface-0"],[1,"font-medium","no-underline","ml-2","text-primary","text-right","cursor-pointer"],["label","Sign In","icon","pi pi-user",1,"w-full"],["header","Description List","containerClass","bg-surface-0 dark:bg-surface-950 px-6 py-20 md:px-12 lg:px-20","free","",3,"code"],[1,"bg-surface-0","dark:bg-surface-950"],[1,"font-medium","text-3xl","text-surface-900","dark:text-surface-0","mb-4"],[1,"text-surface-500","dark:text-surface-300","mb-8"],[1,"list-none","p-0","m-0"],[1,"flex","items-center","py-4","px-2","border-t","border-surface-200","dark:border-surface-700","flex-wrap"],[1,"text-surface-500","dark:text-surface-300","w-6/12","md:w-2/12","font-medium"],[1,"text-surface-900","dark:text-surface-0","w-full","md:w-8/12","md:order-none","order-1"],[1,"w-6/12","md:w-2/12","flex","justify-end"],["label","Edit","icon","pi pi-pencil","text",""],["label","Crime","styleClass","mr-2"],["label","Drama","styleClass","mr-2"],["label","Thriller"],[1,"flex","items-center","py-4","px-2","border-t","border-b","border-surface-200","dark:border-surface-700","flex-wrap"],[1,"text-surface-900","dark:text-surface-0","w-full","md:w-8/12","md:order-none","order-1","leading-normal"],["header","Card","containerClass","px-6 py-20 md:px-12 lg:px-20","free","",3,"code"],[1,"bg-surface-0","dark:bg-surface-900","p-6","shadow","rounded"],[1,"text-3xl","font-medium","text-surface-900","dark:text-surface-0","mb-4"],[1,"font-medium","text-surface-500","dark:text-surface-300","mb-4"],[1,"border-2","border-dashed","border-surface-200","dark:border-surface-700",2,"height","150px"]],template:function(c,a){c&1&&(e(0,"div")(1,"block-viewer",0)(2,"div",1)(3,"div",2)(4,"section")(5,"span",3),i(6,"Create the screens "),t(),e(7,"div",4),i(8,"your visitors deserve to see"),t(),e(9,"p",5),i(10,"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."),t(),r(11,"p-button",6)(12,"p-button",7),t()(),e(13,"div",8),r(14,"img",9),t()()(),e(15,"block-viewer",10)(16,"div",11)(17,"div",12)(18,"span",13),i(19,"One Product, "),t(),e(20,"span",14),i(21,"Many Solutions"),t()(),e(22,"div",15),i(23,"Ac turpis egestas maecenas pharetra convallis posuere morbi leo urna."),t(),e(24,"div",16)(25,"div",17)(26,"span",18),r(27,"i",19),t(),e(28,"div",20),i(29,"Built for Developers"),t(),e(30,"span",21),i(31,"Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur."),t()(),e(32,"div",17)(33,"span",18),r(34,"i",22),t(),e(35,"div",20),i(36,"End-to-End Encryption"),t(),e(37,"span",21),i(38,"Risus nec feugiat in fermentum posuere urna nec. Posuere sollicitudin aliquam ultrices sagittis."),t()(),e(39,"div",17)(40,"span",18),r(41,"i",23),t(),e(42,"div",20),i(43,"Easy to Use"),t(),e(44,"span",21),i(45,"Ornare suspendisse sed nisi lacus sed viverra tellus. Neque volutpat ac tincidunt vitae semper."),t()(),e(46,"div",17)(47,"span",18),r(48,"i",24),t(),e(49,"div",20),i(50,"Fast & Global Support"),t(),e(51,"span",21),i(52,"Fermentum et sollicitudin ac orci phasellus egestas tellus rutrum tellus."),t()(),e(53,"div",17)(54,"span",18),r(55,"i",25),t(),e(56,"div",20),i(57,"Open Source"),t(),e(58,"span",21),i(59,"Nec tincidunt praesent semper feugiat. Sed adipiscing diam donec adipiscing tristique risus nec feugiat. "),t()(),e(60,"div",26)(61,"span",18),r(62,"i",27),t(),e(63,"div",20),i(64,"Trusted Securitty"),t(),e(65,"span",21),i(66,"Mattis rhoncus urna neque viverra justo nec ultrices. Id cursus metus aliquam eleifend."),t()()()()(),e(67,"block-viewer",28)(68,"div",29)(69,"div",30),i(70,"Pricing Plans"),t(),e(71,"div",31),i(72,"Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit numquam eligendi quos."),t(),e(73,"div",16)(74,"div",32)(75,"div",33)(76,"div",34)(77,"div",35),i(78,"Basic"),t(),e(79,"div",36),i(80,"Plan description"),t(),r(81,"hr",37),e(82,"div",38)(83,"span",39),i(84,"$9"),t(),e(85,"span",40),i(86,"per month"),t()(),r(87,"hr",37),e(88,"ul",41)(89,"li",42),r(90,"i",43),e(91,"span",13),i(92,"Arcu vitae elementum"),t()(),e(93,"li",42),r(94,"i",43),e(95,"span",13),i(96,"Dui faucibus in ornare"),t()(),e(97,"li",42),r(98,"i",43),e(99,"span",13),i(100,"Morbi tincidunt augue"),t()()(),r(101,"hr",44)(102,"p-button",45),t()()(),e(103,"div",32)(104,"div",33)(105,"div",34)(106,"div",35),i(107,"Premium"),t(),e(108,"div",36),i(109,"Plan description"),t(),r(110,"hr",37),e(111,"div",38)(112,"span",39),i(113,"$29"),t(),e(114,"span",40),i(115,"per month"),t()(),r(116,"hr",37),e(117,"ul",41)(118,"li",42),r(119,"i",43),e(120,"span",13),i(121,"Arcu vitae elementum"),t()(),e(122,"li",42),r(123,"i",43),e(124,"span",13),i(125,"Dui faucibus in ornare"),t()(),e(126,"li",42),r(127,"i",43),e(128,"span",13),i(129,"Morbi tincidunt augue"),t()(),e(130,"li",42),r(131,"i",43),e(132,"span",13),i(133,"Duis ultricies lacus sed"),t()()(),r(134,"hr",44)(135,"p-button",45),t()()(),e(136,"div",32)(137,"div",33)(138,"div",46)(139,"div",35),i(140,"Enterprise"),t(),e(141,"div",36),i(142,"Plan description"),t(),r(143,"hr",37),e(144,"div",38)(145,"span",39),i(146,"$49"),t(),e(147,"span",40),i(148,"per month"),t()(),r(149,"hr",37),e(150,"ul",41)(151,"li",42),r(152,"i",43),e(153,"span",13),i(154,"Arcu vitae elementum"),t()(),e(155,"li",42),r(156,"i",43),e(157,"span",13),i(158,"Dui faucibus in ornare"),t()(),e(159,"li",42),r(160,"i",43),e(161,"span",13),i(162,"Morbi tincidunt augue"),t()(),e(163,"li",42),r(164,"i",43),e(165,"span",13),i(166,"Duis ultricies lacus sed"),t()(),e(167,"li",42),r(168,"i",43),e(169,"span",13),i(170,"Imperdiet proin"),t()(),e(171,"li",42),r(172,"i",43),e(173,"span",13),i(174,"Nisi scelerisque"),t()()(),r(175,"hr",47)(176,"p-button",48),t()()()()()(),e(177,"block-viewer",49)(178,"div",50)(179,"div",51)(180,"div",52),r(181,"i",53),i(182,"\xA0POWERED BY DISCORD"),t(),e(183,"div",54),i(184,"Join Our Design Community"),t(),e(185,"div",55),i(186,"Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit numquam eligendi quos."),t(),r(187,"p-button",56),t()()(),e(188,"block-viewer",57)(189,"div",58)(190,"div",59),i(191,"\u{1F525} Hot Deals!"),t(),e(192,"div",60)(193,"span",61),i(194,"Libero voluptatum atque exercitationem praesentium provident odit."),t()(),e(195,"a",62)(196,"a",63)(197,"span",64),i(198,"Learn More"),t()()(),e(199,"a",65),r(200,"i",66),t()()(),e(201,"div",67),i(202,"Application UI"),t(),e(203,"block-viewer",68)(204,"div",69)(205,"ul",70)(206,"li")(207,"a",71),i(208,"Application"),t()(),e(209,"li",72),r(210,"i",73),t(),e(211,"li")(212,"span",74),i(213,"Analytics"),t()()(),e(214,"div",75)(215,"div")(216,"div",76),i(217,"Customers"),t(),e(218,"div",77)(219,"div",78),r(220,"i",79),e(221,"span"),i(222,"332 Active Users"),t()(),e(223,"div",78),r(224,"i",80),e(225,"span"),i(226,"9402 Sessions"),t()(),e(227,"div",81),r(228,"i",82),e(229,"span"),i(230,"2.32m Avg. Duration"),t()()()(),e(231,"div",83),r(232,"p-button",84)(233,"p-button",85),t()()()(),e(234,"block-viewer",86)(235,"div",87)(236,"div",16)(237,"div",88)(238,"div",89)(239,"div",90)(240,"div")(241,"span",91),i(242,"Orders"),t(),e(243,"div",92),i(244,"152"),t()(),e(245,"div",93),r(246,"i",94),t()(),e(247,"span",95),i(248,"24 new "),t(),e(249,"span",96),i(250,"since last visit"),t()()(),e(251,"div",88)(252,"div",89)(253,"div",90)(254,"div")(255,"span",91),i(256,"Revenue"),t(),e(257,"div",92),i(258,"$2.100"),t()(),e(259,"div",97),r(260,"i",98),t()(),e(261,"span",95),i(262,"%52+ "),t(),e(263,"span",96),i(264,"since last week"),t()()(),e(265,"div",88)(266,"div",89)(267,"div",90)(268,"div")(269,"span",91),i(270,"Customers"),t(),e(271,"div",92),i(272,"28441"),t()(),e(273,"div",99),r(274,"i",100),t()(),e(275,"span",95),i(276,"520 "),t(),e(277,"span",96),i(278,"newly registered"),t()()(),e(279,"div",88)(280,"div",89)(281,"div",90)(282,"div")(283,"span",91),i(284,"Comments"),t(),e(285,"div",92),i(286,"152 Unread"),t()(),e(287,"div",101),r(288,"i",102),t()(),e(289,"span",95),i(290,"85 "),t(),e(291,"span",96),i(292,"responded"),t()()()()()(),e(293,"block-viewer",103)(294,"div",104)(295,"div",105),r(296,"img",106),e(297,"div",107),i(298,"Welcome Back"),t(),e(299,"span",108),i(300,"Don't have an account?"),t(),e(301,"a",109),i(302,"Create today!"),t()(),e(303,"div")(304,"label",110),i(305,"Email"),t(),r(306,"input",111),e(307,"label",112),i(308,"Password"),t(),r(309,"input",113),e(310,"div",114)(311,"div",38)(312,"p-checkbox",115),O("ngModelChange",function(o){return _(a.checked,o)||(a.checked=o),o}),t(),e(313,"label",116),i(314,"Remember me"),t()(),e(315,"a",117),i(316,"Forgot password?"),t()(),r(317,"p-button",118),t()()(),e(318,"block-viewer",119)(319,"div",120)(320,"div",121),i(321,"Movie Information"),t(),e(322,"div",122),i(323,"Morbi tristique blandit turpis. In viverra ligula id nulla hendrerit rutrum."),t(),e(324,"ul",123)(325,"li",124)(326,"div",125),i(327,"Title"),t(),e(328,"div",126),i(329,"Heat"),t(),e(330,"div",127),r(331,"p-button",128),t()(),e(332,"li",124)(333,"div",125),i(334,"Genre"),t(),e(335,"div",126),r(336,"p-chip",129)(337,"p-chip",130)(338,"p-chip",131),t(),e(339,"div",127),r(340,"p-button",128),t()(),e(341,"li",124)(342,"div",125),i(343,"Director"),t(),e(344,"div",126),i(345,"Michael Mann"),t(),e(346,"div",127),r(347,"p-button",128),t()(),e(348,"li",124)(349,"div",125),i(350,"Actors"),t(),e(351,"div",126),i(352,"Robert De Niro, Al Pacino"),t(),e(353,"div",127),r(354,"p-button",128),t()(),e(355,"li",132)(356,"div",125),i(357,"Plot"),t(),e(358,"div",133),i(359," A group of professional bank robbers start to feel the heat from police when they unknowingly leave a clue at their latest heist. "),t(),e(360,"div",127),r(361,"p-button",128),t()()()()(),e(362,"block-viewer",134)(363,"div",135)(364,"div",136),i(365,"Card Title"),t(),e(366,"div",137),i(367,"Vivamus id nisl interdum, blandit augue sit amet, eleifend mi."),t(),r(368,"div",138),t()()()),c&2&&(s(),l("code",a.block1),s(14),l("code",a.block2),s(52),l("code",a.block3),s(110),l("code",a.block4),s(11),l("code",a.block5),s(15),l("code",a.block6),s(31),l("code",a.block7),s(59),l("code",a.block8),s(19),P("ngModel",a.checked),s(6),l("code",a.block9),s(44),l("code",a.block10))},dependencies:[p,U,q,F,T,L,A,B,V],encapsulation:2})}return n})();var be=[{path:"",data:{breadcrumb:"Free Blocks"},component:H}];export{be as default};

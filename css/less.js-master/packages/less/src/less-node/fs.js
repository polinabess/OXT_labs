let fs;
try
{
    fs = require('graceful-fs');
}
catch (e)
{
    fs = require('css/less.js-master/packages/less/src/less-node/fs');
}
export default fs;

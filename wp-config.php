<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/support/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'msbd' );

/** MySQL database username */
define( 'DB_USER', 'root' );

/** MySQL database password */
define( 'DB_PASSWORD', '' );

/** MySQL hostname */
define( 'DB_HOST', 'localhost' );

/** Database Charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The Database Collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         'hfIUM(=Mi3)qCHA>(mi )eF#Oc=e(KEaHzte8?z[Gn815&j,;;& ?gwx53 $^ClJ' );
define( 'SECURE_AUTH_KEY',  '}N}tYmya$CSIClD{h>#Ab]Bg,}^^01@Z)dZ!rF1X~&bbbSAa0Rc.+b)%burghCTY' );
define( 'LOGGED_IN_KEY',    '_Z|?P1.SuQR3IqnzlZ^aZkGBeh*/a|DWF*=l oMJMI]w^r0kHEJ`90b<l{!nP2T9' );
define( 'NONCE_KEY',        '1e>-U0oM0=BPR;RO >=@+XNX?bdGm@;]q>!^#[>`6# tc`.4S1c:i62y_kpa+k51' );
define( 'AUTH_SALT',        'A!RE#,{YJ*TN!zt)$w^RGhggEbJtoyEQ0^9=CFoQ0OGuv85>ZkDSZ/&VAD<WZ{mQ' );
define( 'SECURE_AUTH_SALT', '  A0&m{zeXb<}WW2=)|khxA6M)xI=;b0HM|kX1%XFOIY#pI3_IAdG%zFPLh~R*@k' );
define( 'LOGGED_IN_SALT',   'kwe_h<Y?Lnki;HXVD@rx~>R)*-7BnFB`T>B{?oJxJS[dyv>Sr;VBrnRB`.s]WB&&' );
define( 'NONCE_SALT',       '=FXK8M=l;@6v r#r/J*|d7pJ51AX<Jh`;D6|^oH.H2:UXmId0D4&c_!?#F!jcIhp' );

/**#@-*/

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'msbd_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://wordpress.org/support/article/debugging-in-wordpress/
 */
define( 'WP_DEBUG', false );

/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
